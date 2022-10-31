Operation mySum = Functions.Sum;

//Console.WriteLine( mySum(2,3) );


Show show = Console.WriteLine;
show += Functions.ConsoleShow;
//show("hola mundo");
//Functions.Some("Juan","Guevara", show);

#region Action
Action<string> showMessage = Console.WriteLine;
//Functions.SomeAction("Juan","Guevara", showMessage);

Action<string, string> showMessage2 = (a, b) =>
{
    Console.WriteLine($"{a} {b}");
};
//showMessage2("Hola","Mundo");
Action<string, string, string> showMessage3 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");
//showMessage3("Este","es","texto");
 
#endregion

#region Func
Func<int> numberRandom = () => new Random().Next(0, 100);
//Console.WriteLine(numberRandom());
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);
//Console.WriteLine(numberRandomLimit(10));
#endregion

#region Predicate

Predicate<string> hasSpace = (word) => word.Contains(" ");
Console.WriteLine(hasSpace("beer a"));
var words = new List<string>()
{
    "beer","patito","sandia","hola","c#"
};
var wordsNew = words.FindAll( hasSpace );

#endregion

#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string meesage, string message2);
public delegate void Show3(string meesage, string message2, string message3);
#endregion



public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }


}
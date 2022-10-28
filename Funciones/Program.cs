namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int c = a + b;
            int d = a + b;

            Show();
            Sum(a,b);

            int m = Mul(a,b);

            Console.WriteLine(m);
        }

        static void Show()
        {
            Console.WriteLine("Hola soy un texto que se imprime desde función");
        }

        static void Sum(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        static int Mul(int num1, int num2)
        {
           return num1 * num2;
        }

    }
}
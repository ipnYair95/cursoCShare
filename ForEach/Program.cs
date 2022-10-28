using System.Collections.Generic;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var numbers = new List<int>() { 5,4,3,2,1 };

            foreach ( var number in numbers)
            {
                Console.WriteLine(number);
            }


            Show(numbers);
            //
            numbers.Insert(0, 100);   
            Show(numbers);

            //
            if (numbers.Contains(33))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("no existe");
            }

            //
            int pos = numbers.IndexOf(4);
            Console.WriteLine(pos);

            pos = numbers.IndexOf(55);
            Console.WriteLine(pos);

            numbers.Sort();
            Show(numbers);

            string name = "Hector";
            name.ToUpper();
            Console.WriteLine(name);

            numbers.AddRange( new List<int>() { 10,11,12,13,14} );

            Show(numbers);

            
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
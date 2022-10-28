using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1,2,3,4,
            };

            Console.WriteLine(numbers2.Count);

            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "Mexico", "Argentina"
            };

            Console.WriteLine(countries.Count);


        }
    }
}
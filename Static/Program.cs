namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            People p1 = new People()
            {
                Name = "Hector",
                Age = 34
            };

            Console.WriteLine(People.Count);

            People p2 = new People()
            {
                Name = "Juan",
                Age = 30
            };

            Console.WriteLine(People.Count);

            Console.WriteLine(People.GetCount());
        }

        public class People
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public static int Count = 0;

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $" Esta clase se ha utilizado {Count} veces ";
            }

        }

        public static class A
        {
            public static void Some()
            {
                Console.WriteLine("algo");
            }
        }
    }
}
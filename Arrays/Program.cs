namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[4]
            {
                "1",null,"3",null
            };          

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);

            friends[3] = "Algo";

            Console.WriteLine(friends[3]);

        }
    }
}
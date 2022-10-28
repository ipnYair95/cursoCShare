namespace SentenciaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[3]
            {
                "pepe","laura","luis"
            };

            bool run = true;

            for (int i = 0; i < friends.Length && run; i++)
            {
                Console.WriteLine(friends[i]);
            }

        }
    }
}
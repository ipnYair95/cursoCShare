namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while( i < 10)
            {
                Console.WriteLine("Iteracion de i " +  i);
                i++;
            }

            int j = 0;

            while (i < 100)
            {
                if ( j > 10 )
                {
                    break;
                }

                Console.WriteLine("Iteracion de j " + j);
                j++;
            }

            string[] friends = new string[4]
            {
                "1","2","3","4"
            };

            int index = 0;
            while ( index < friends.Length )
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;

            do
            {
                Show();
            } while ( run );

        }

        static void Show()
        {
            Console.WriteLine("Entro 1 vez");
        }
    }
}
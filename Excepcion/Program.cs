using System.IO;

namespace Excepcion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"C:\Desarrollos\C#\1-Variables\Excepcion\Hola.txt");
                Console.WriteLine(content);

                throw new Exception("Se murio");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("siempre se ejcuta");
            }

            Console.WriteLine("Seguimos");

            try
            {
                Beer beer = new Beer()
                {
                    Name = "London",
                    //Brand = "Ls"
                };

                Console.WriteLine( beer.ToString() );

            }
            catch (InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            public override string ToString()
            {
                if( Name == null || Brand == null)
                {
                    throw new InvalidBeerException();
                }

                return $" cerveza: {Name} - Brand: {Brand}";
            }
        }

        public class InvalidBeerException : Exception
        {
            public InvalidBeerException() : base("La cerveza no tiene nombre o marca")
            {

            }
        }
    }
}
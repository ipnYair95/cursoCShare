namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 5;

            switch (op)
            {
                case 1:
                    Console.WriteLine("seleccionaste el 1");
                    break;
                case 2:
                    Console.WriteLine("seleciconaste el 2");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("fuera de rango");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("Seleciconaste una opcion entre 4 y 10");
                    break;
                default:
                    Console.WriteLine("no existe la opcion");
                    break;
            }

        }
    }
}
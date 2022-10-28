namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburoncin", 10),
                new Shark("Jwas", 65)
            };

            IFish[] fishes = new IFish[]
            {
                new Siren(100),
                new Shark("Tiburoncin", 15)
            };

            ShowFish(sharks);            
            ShowAnimlas(sharks);
            ShowFish(fishes);

        }


        public static void ShowFish(IFish[] fishes)
        {
            Console.WriteLine("- Mostramos los peces -");

            int i = 0;
            while (i < fishes.Length)
            {
                Console.WriteLine(fishes[i].Swim());
                i++;
            }
        }

        public static void ShowAnimlas(IAnimal[] animals)
        {
            Console.WriteLine("- Mostramos los animales -");

            int i = 0;
            while ( i < animals.Length)
            {
                Console.WriteLine(animals[i].Name );
                i++;
            }
        }

    }

    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int Speed)
        {
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"La sirena nada {Speed} km/h";
        }
    }

    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }

        public string Swim()
        {
            return $"{Name} nada {Speed} km/h";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }

        public string Swim();

    }
}
abstract class Animal
{
    public virtual string Sound { get; set; }
    public virtual int Milk { get; set; }
}

class Cow : Animal
{
    private Random ran = new Random();

    public Cow()
    {
        Sound = "Muuuu";
        Milk = ran.Next(0, 20);
    }
}

class Sheep : Animal
{
    private Random ran = new Random();

    public Sheep()
    {
        Sound = "Baaaa";
        Milk = ran.Next(0, 15);
    }
}

class Goat : Animal
{
    private Random ran = new Random();

    public Goat()
    {
        Sound = "Beeee";
        Milk = ran.Next(0, 10);
    }
}

class Program
{
    static void TrackAnimalCount(Dictionary<string, int> counts, string animalType)
    {
        if (counts.ContainsKey(animalType))
        {
            counts[animalType]++;
        }
        else
        {
            counts[animalType] = 1;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the number of animals: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Animal[] ani = new Animal[n];
        bool c = false, s = false, g = false;
        Dictionary<string, int> animalCounts = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Choose an animal type for animal {i + 1}:");
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Sheep");
            Console.WriteLine("3. Goat");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ani[i] = new Cow();
                    TrackAnimalCount(animalCounts, "Cow");
                    c = true;
                    break;
                case 2:
                    ani[i] = new Sheep();
                    TrackAnimalCount(animalCounts, "Sheep");
                    s = true;
                    break;
                case 3:
                    ani[i] = new Goat();
                    TrackAnimalCount(animalCounts, "Goat");
                    g = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                    i--; 
                    break;
            }
        }

        // a
        if(c&&s&&g) { Console.WriteLine("Co 3 tieng keu tat ca"); }
        else if(c&&s) { Console.WriteLine("Co 2 tieng keu tat ca"); }
        else if (s&&g) { Console.WriteLine("Co 2 tieng keu tat ca"); }
        else if (c && g)
        {
            Console.WriteLine("Co 2 tieng keu tat ca");
        }
        else if (c)
        {
            Console.WriteLine("Co tieng bo");
        }
        else if (s)
        {
            Console.WriteLine("Co tieng cuu");
        }
        else if (g)
        {
            Console.WriteLine("Co tieng de");
        }
        else
        {
            Console.WriteLine("ko co tieng keu nao ca");
        }
        //b
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += ani[i].Milk;
        }
        Console.WriteLine(sum);
    }
}
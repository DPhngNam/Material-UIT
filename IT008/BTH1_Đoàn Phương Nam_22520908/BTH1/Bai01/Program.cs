namespace Bai01
{
    class Program
    {
        public static bool checkLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert moth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Choose your side: ");
            int ops = Convert.ToInt32(Console.ReadLine());
            switch (ops)
            {
                case 1:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        months[1] = 29;
                    }
                    break;

                case 2:
                    if (checkLeapYear(year))
                    {
                        months[1] = 29;
                    }
                    break;
            }

            Console.WriteLine(months[month]);
        }
    }
}
namespace Bai02
{
    class Program
    {
        static int A(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                if (i % 2 != 0) sum += i;
            }
            return sum;
        }
        static bool is_prime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; ++i)
                if (n % i == 0)
                    return false;

            return true;
        }
        static int B(int[] a)
        {
            int count = 0;
            foreach (int i in a)
            {
                if(is_prime(i)) count++;
            }
            return count;
        }
        static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }

        static int C(int[] a)
        {
            int check = -1;
            int maxi = Int32.MaxValue;
            bool flag = false;
            foreach (int i in a)
            {
                if (IsPerfectSquare(i))
                {
                    flag = true;
                    maxi = Math.Min(maxi, i);
                }
            }
            if (flag) return maxi;
            return check;
        }
        static void Main(string[] args)
        {
            Random ran = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i <  n; i++)
            {
                a[i] = ran.Next(1,101);
            }
            
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int ops = Convert.ToInt32(Console.ReadLine());
            switch (ops)
            {
                case 1:
                    Console.WriteLine(A(a));
                    break;

                case 2:
                    Console.WriteLine(B(a));
                    break;
                case 3:
                    Console.WriteLine(C(a));
                    break;
            }

        }
    }
}
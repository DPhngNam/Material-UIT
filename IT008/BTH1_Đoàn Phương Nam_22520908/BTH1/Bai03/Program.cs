using System;

namespace Bai03
{
    class Program
    {
        static void Xuat(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Min_Max(int[,] a, int n, int m)
        {
            int mini = int.MaxValue;
            int maxi = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mini = Math.Min(mini, a[i, j]);
                    maxi = Math.Max(maxi, a[i, j]);
                }
            }
            Console.WriteLine("Max: " + maxi);
            Console.WriteLine("Min: " + mini);
        }

        static void Row_Max(int[,] a, int n, int m)
        {
            int maxi = int.MinValue;
            int rowIndex = -1;

            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < m; j++)
                {
                    rowSum += a[i, j];
                }
                if (rowSum > maxi)
                {
                    maxi = rowSum;
                    rowIndex = i;
                }
            }
            Console.WriteLine("Row with the max sum: " + rowIndex);
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; ++i)
                if (n % i == 0)
                    return false;

            return true;
        }

        static int SumNotPrime(int[,] a, int n, int m)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!IsPrime(a[i, j]))
                        sum += a[i, j];
                }
            }
            return sum;
        }

        static void DeleteRow(int[,] a, ref int n, int m, int k)
        {
            for (int i = k; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }
            n--;
        }

        static void DeleteMaxColumn(int[,] a, ref int n, ref int m)
        {
            int maxColumnValue = int.MinValue;
            int maxColumnIndex = -1;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, j] > maxColumnValue)
                    {
                        maxColumnValue = a[i, j];
                        maxColumnIndex = j;
                    }
                }
            }

            if (maxColumnIndex >= 0)
            {
                // Shift columns to delete the max column
                for (int i = 0; i < n; i++)
                {
                    for (int j = maxColumnIndex; j < m - 1; j++)
                    {
                        a[i, j] = a[i, j + 1];
                    }
                }
                m--; // Decrease the number of columns
                Console.WriteLine("Column with the maximum value (" + maxColumnValue + ") deleted.");
            }
            else
            {
                Console.WriteLine("No column to delete.");
            }
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Random ran = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = ran.Next(1, 1001);
                }
            }

            int t = 6;
            while (t > 0)
            {
                Console.Write("Choose operation: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Xuat(a, n, m);
                        break;
                    case 2:
                        Min_Max(a, n, m);
                        break;
                    case 3:
                        Row_Max(a, n, m);
                        break;
                    case 4:
                        Console.WriteLine("Sum of non-prime numbers: " + SumNotPrime(a, n, m));
                        break;
                    case 5:
                        Xuat(a, n, m);
                        Console.Write("Enter row index to delete: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        if (k >= 0 && k < n)
                        {
                            DeleteRow(a, ref n, m, k);
                            Console.WriteLine("Row deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid row index.");
                        }
                        break;
                    case 6:
                        Xuat(a, n, m);
                        DeleteMaxColumn(a, ref n, ref m);
                        
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
                t--;
            }
        }
    }
}

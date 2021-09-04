using System;

namespace test2021
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(While10(int.Parse(Console.ReadLine())));
        }

        static int Integer8(int n)
        {
            return n / 10 + (n % 10) * 10;
        }

        static int Integer27(int k)
        {
            return (k + 5) % 7;
        }

        // static bool Bolean39(int x1, int x2, int y1, int y2)
        // {
        //     return x1==x2 || y1==y2 ||  
        // }
        static int If18(int[] arr)
        {
            if (arr[0] == arr[1])
                return 3;
            else if (arr[2] == arr[1])
                return 1;
            else return 2;
        }

        static double If27(double x)
        {
            if (x < 0)
                return 0;
            else if (x % 2 == 0)
                return 1;
            else if (x % 2 == 1)
                return -1;
            else if (Math.Ceiling(x) % 2 == 0)
                return 1;
            else return -1;
        }

        static double For25(double x, double n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result -= Math.Pow(x, i) / i;
                }
                else
                    result += Math.Pow(x, i) / i;
            }
            return result;
        }

        static double While10(int n)
        {
            int k = 0;
            while (Math.Pow(3, k) < n)
            {
                k++;
            }

            return k - 1;
        }

        static double Series23(int n)
        {
            int result=0;
            int[] arr = new int[n];
            for (int i = 1; i < n-1; i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    result=0;
                else if (arr[i] < arr[i + 1] && arr[i] < arr[i - 1])
                    result=0;
                else
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        static bool IsPrime(int n)
        {
            bool result=true;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    result=false;
                    break;
                }
            }
            return result;
        }

        static int DigitCount(int k)
        {
            string number =k.ToString();
            return number.Length;
        }

        static int Array28(int n)
        {
            int[] a = new int[n];
            int result = a[2];
            for (int i = 4; i < n; i += 2)
            {
                if (a[i] < result)
                {
                    result = a[i];
                }
            }
            return result;
        }

        static int Array47(int n)
        {
            int result = 1;
            int[] a = new int[n];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i] != j && j==i-1)
                        result++;
                }
            }
            return result;
        }
    }
}



















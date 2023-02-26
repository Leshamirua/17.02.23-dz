using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._23_dz
{
    internal class Program
    {
        public static int[] evenArrayNum(int[] array)
        {
            int count = 0;
            foreach (var i in array)
            {
                if (i % 2 == 0) count++;
            }
            int[] res = new int[count];
            count= 0;
            foreach (var i in array)
            {
                if (i % 2 == 0)
                {
                    res[count] = i;
                    count++;
                }
            }
            return res;
        }
        public static int[] oddArrayNum(int[] array)
        {
            int count = 0;
            foreach (var i in array)
            {
                if (i % 2 != 0) count++;
            }
            int[] res = new int[count];
            count = 0;
            foreach (var i in array)
            {
                if (i % 2 != 0)
                {
                    res[count] = i;
                    count++;
                }
            }
            return res;
        }
        public static int[] primeArrayNum(int[] array)
        {
            int count = 0;
            foreach (var i in array)
            {
                if (i % 2 != 0) count++;
            }
            int[] res = new int[count];
            count = 0;
            foreach (var i in array)
            {
                if (i == 1) continue;
                if (i == 2) res[count] = i;

                var limit = Math.Ceiling(Math.Sqrt(i));

                for (int a = 2; a <= limit; ++a)
                    if (a % a == 0)
                        continue;
                res[count] = i;
            }
            return res;
        }
                private static bool IsPerfectSquare(int num)
        {
            int sq = (int)Math.Sqrt(num);
            return sq * sq == num;
        }

        public static int[] fibonacciArrayNum(int[] arr)
        {
            int[] res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }
            int count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (IsPerfectSquare(arr[i] * arr[i] + 4) || IsPerfectSquare(arr[i] * arr[i] - 4))
                {
                    count++;
                }
                else res[i] = -1;
            }
            int[] _res = new int[count];
            foreach(int i in _res) 
            {
                foreach(int j in res)
                {
                    if (arr[j] == -1) continue;
                    _res[i] = res[j];
                }
            }
            return _res;
        }
        public delegate int[] Task1(int[] arr);
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.ReadKey();
            Task1 a = new Task1(evenArrayNum);
            a += oddArrayNum;
            a += primeArrayNum;
            a += fibonacciArrayNum;
            int[] temp = a.Invoke(arr);
        }
    }
}

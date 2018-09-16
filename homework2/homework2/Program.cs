using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an int :");
            string sInt = Console.ReadLine();
            int nInt = Int32.Parse(sInt);

            //第六题
            Program program = new Program();
            program.MyPrimeFactor(nInt);

            //第七题
            int[] test = { 23, 45, 12, 33, 55, 777, 233, 6 };
            program.ArrayO(test);

            //第九题
            Console.WriteLine("The prime numbers in 100:");
            program.AS();
        }

        void MyPrimeFactor(int n)
        {
            Console.WriteLine("prime factors：");
            
            while (n % 2 == 0)
            {
                Console.WriteLine("2 ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }
            if (n > 2)
                Console.WriteLine(n);
        }

        void ArrayO(int []n)
        {
            int length = 0;
            int total = 0;
            foreach(int i in n)
            {
                total += i;
                length++;
            }
            //升序排序
            Array.Sort(n);
            Console.WriteLine("The total:{0}",total);
            Console.WriteLine("The average value:{0}", total / length);
            Console.WriteLine("The minimum value of the integer array:{0}", n[0]);
            Console.WriteLine("The maximum value of the integer array:{0}", n[length-1]);
        }

        void AS()
        {
            Console.Write(2 + "");
            for (int i = 3; i < 100; i+=2)
            {
                int n = 0;
                for (int j = 3; j <= Math.Sqrt(100); j++)
                {

                    if (i % j == 0 && i != j)
                    {
                        goto outer;
                    }

                }
                Console.Write("  " + i);
                n++;
                if (n % 10 == 0)
                    Console.WriteLine();
            outer:;
            }
        }
    }
}


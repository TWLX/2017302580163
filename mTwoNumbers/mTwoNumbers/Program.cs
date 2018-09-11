using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "", num2 = "";
            Console.WriteLine("Please input a numbers :");
            num1 = Console.ReadLine();
            Console.WriteLine("Please input a number again :");
            num2 = Console.ReadLine();
            int _num1 = Int32.Parse(num1);
            int _num2 = Int32.Parse(num2);
            int num = _num1 * _num2;
            Console.WriteLine("Product of two numbers :" + num);
        }
    }
}

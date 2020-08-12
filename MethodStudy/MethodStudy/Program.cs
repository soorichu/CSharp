using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStudy
{
    class Calculator
    {
        public static int Plus(int a, int b = 10)
        {
            return a + b;
        }
        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static void Swap(ref int a, ref int b) {
            int temp = b;
            b = a;
            a = temp;
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;
            for(int i=0; i<args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
    }

    class Product
    {
        private int price = 100;
        public ref int GetPrice() {
            return ref price;
        }
        public void PrintPrice() {
            Console.WriteLine($"Price : {price}");
        }
    }
    class Program
    {
        public static void Mean(double a, double b, double c, 
            double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        static void Main(string[] args)
        {
            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);
            Console.WriteLine("평균 : {0}", mean);

            int a = 3; int b = 4;
            int result = Calculator.Plus(a, b);
            Console.WriteLine(result);

            result = Calculator.Plus(1, 2, 3);
            Console.WriteLine(result);

            double result2 = Calculator.Plus(1.0, 2.4);
            Console.WriteLine(result2);


            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Calculator.Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            carrot.PrintPrice();
            ref_local_price = 200;
            carrot.PrintPrice();

            Console.WriteLine(Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
            Console.WriteLine(Calculator.Plus(3));
            Console.WriteLine(Calculator.Plus(3, 4));
        }
    }
}

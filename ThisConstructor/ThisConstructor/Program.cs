using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisConstructor
{
    class MyClass {
        public int a, b, c;

        public MyClass()
        {
            this.a = 1234;
        }
        public MyClass(int b) : this()
        {
         //   this.a = 1234;
            this.b = b;
        }
        public MyClass(int b, int c) : this(b)
        {
         //   this.a = 1234;
         //   this.b = b;
            this.c = c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my1 = new MyClass();
            MyClass my2 = new MyClass(20);
            MyClass my3 = new MyClass(20, 30);
            Console.WriteLine($"{my1.a}, {my1.b}, {my1.c}");
            Console.WriteLine($"{my2.a}, {my2.b}, {my2.c}");
            Console.WriteLine($"{my3.a}, {my3.b}, {my3.c}");
        }
    }
}

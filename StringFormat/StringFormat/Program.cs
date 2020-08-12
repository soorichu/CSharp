using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = string.Format("ABC{0, 10}GHI", "DEF");
            string result2 = string.Format("ABC{0, -10}GHI", "DEF");
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            string fmt = "{0, -20}{1, -15}{2, 30}";
            Console.WriteLine(fmt, "Phublisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 programming");

            Console.WriteLine("10진수 : {0:D}", 123);
            Console.WriteLine("10진수 : {0:D5}", 123);
            Console.WriteLine("16진수 : {0:X}", 0xFF1234);
            Console.WriteLine("16진수 : {0:X8}", 0xFF1234);
            Console.WriteLine("숫자 : {0:N}", 123456789);
            Console.WriteLine("숫자 : {0:N0}", 123456789);
            Console.WriteLine("고정소숫점 : {0:F}", 123.45);
            Console.WriteLine("고정소숫점 : {0:F5}", 123.45);
            Console.WriteLine("지수 : {0:E}", 123.456789);

            DateTime dt = new DateTime(2020, 8, 12, 16, 4, 22);
            Console.WriteLine("12 시간 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24 시간 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            //using System.Globalization; 맨 상단에 넣어주세요.
            CultureInfo ciKo = new CultureInfo("en-US");
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));

            int number = 30100;
            string name = "정수영";
            Console.WriteLine("{0:D} {1, 10}", number, name);
            Console.WriteLine($"{number:D} {name, 10}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Rectangle C# 5.0 Version ==============");
            var rectangle5 = new Rectangle5(5);
            Console.WriteLine("Width set in constructor: {0}", rectangle5.Width);
            Console.WriteLine("Height set by constructor default value: {0}", rectangle5.Height);
            Console.WriteLine("Area calculated in property body using namespace import: {0}", rectangle5.Area);
            Console.WriteLine("ToString() using property string literals: {0}", rectangle5);

            Console.Write("Logger null: ");
            rectangle5.Log(null);
            Console.WriteLine();

            Console.Write("Logger not null: ");
            rectangle5.Log(Console.Write);
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("============== Rectangle C# 6.0 Version ==============");
            var rectangle6 = new Rectangle6(5);
            Console.WriteLine("Width set in constructor: {0}", rectangle6.Width);
            Console.WriteLine("Height set by property default value: {0}", rectangle6.Height);
            Console.WriteLine("Area calculated in property expression using static import: {0}", rectangle6.Area);
            Console.WriteLine("ToString() using property nameof compile-time function: {0}", rectangle6);
            Console.WriteLine();

            Console.Write("Logger null: ");
            rectangle6.Log(null);
            Console.WriteLine();

            Console.Write("Logger not null: ");
            rectangle6.Log(Console.Write);
            Console.WriteLine();

            Console.WriteLine("Press return to exit");

            Console.Read();
        }
    }
}

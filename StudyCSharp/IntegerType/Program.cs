using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MaxValue;
            //byte b = byte.MinValue;

            //short c = short.MinValue;
            //ushort d = ushort.MaxValue;

            //int e = int.MaxValue;
            //uint f = uint.MinValue;

            //long g = long.MaxValue;
            //ulong h = ulong.MaxValue;
            //ulong  = 20_000_000_000;
            //Console.WriteLine(i);

            byte a = 240;
            WriteLine($"a={a}");
            byte b = 0b1111_0000;
            WriteLine($"b={b}");
            byte c = 0xF0;
            WriteLine($"c={c}");

            byte d = byte.MaxValue;
            WriteLine($"d={d}");
            d += 1;
            WriteLine($"d={d}");

            float f = float.MaxValue;
            double g = double.MaxValue;

        }
    }
}

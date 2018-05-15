using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static int Beregn(int int1, int int2)
        {
            return (int1 + int2);
        }

        static int Beregn(int int1, int int2, int int3)
        {
            return (Beregn(int1, int2)) + int3;
        }

        static int Beregn(int int1, int int2, int int3, int int4)
        {
            return (Beregn(int1, int2, int3) + int4);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 4, 5)); 
        }
    }
}

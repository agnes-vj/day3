using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class task02
    {
        public static void Run()
        {

            int number = 2;
            decimal dec = 1.1m;
            float f = 2.9f;
            double doub = 3.678908765436578;

           Console.WriteLine((decimal)number);
            double a = 1.0;
            decimal b = 2.1m;
            Console.WriteLine(a + (double)b); //change decimal into double for this occasion doesnt change it permanently
            Console.WriteLine((decimal)a + b);

            double doubleToDec = (double)dec;
            Console.WriteLine(doubleToDec);
            Console.WriteLine(doubleToDec);
            int floatToInt = (int)f; //when changing to int it will Floor it
            Console.WriteLine(floatToInt);
            decimal floatToDec = (decimal)f;
            Console.WriteLine(floatToDec);
            float doubleToFloat = (float)doub;
            Console.WriteLine(doubleToFloat);

        }
    }
}

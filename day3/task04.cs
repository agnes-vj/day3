using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class task04
    {
        public static void Run()
        {
            string numString = "10";
            string parseCheck = "Welcome";
            int num1 = Int32.Parse(numString);
            int num = Convert.ToInt32(numString);
            decimal num2 = Convert.ToDecimal(numString);
            Console.WriteLine("Result = " + (num1 + 5));

            Console.WriteLine("Decimal Result = " + (num2 + (decimal)1.1));



            if (int.TryParse(parseCheck, out num))
            {
                Console.WriteLine("Using TryParse : " + num );
            }
            else
            {
                Console.WriteLine("Unable to Parse");
            }




        }
    }
}

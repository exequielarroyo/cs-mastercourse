using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class Doubles
    {
        public void RunDoubles()
        {
            Console.WriteLine("---DOUBLES");
            double average = 0;
            
            average = (43 + 22) / 3.0;
            Console.WriteLine(average);

            average = 32 / 3.0;
            Console.WriteLine(average);

            average = 1_000 / 3.0;
            Console.WriteLine(average);

            average = 1 / 3.0;
            Console.WriteLine(average);
        }
    }
}

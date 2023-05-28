using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class Decimals
    {
        public void RunDecimals()
        {
            Console.WriteLine("---DECIMALS");

            decimal money = 0;

            money = 32 / 3.0M;
            Console.WriteLine(money);

            money = 1_000 / 3.0M;
            Console.WriteLine(money);

            money = 1 / 3.0M;
            Console.WriteLine(money);

            
        }
    }
}

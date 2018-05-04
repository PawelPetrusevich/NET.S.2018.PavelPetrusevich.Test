using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Console
{
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var bank1 = new Bank("First Bank", stock);
            var bank2 = new Bank("Second Bank", stock);

            var broker = new Broker("First Broker", stock);

            stock.Market();
            Console.ReadKey();
            Console.WriteLine();
            stock.Market();
            Console.ReadKey();
        }


    }
}

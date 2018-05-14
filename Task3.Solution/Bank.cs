using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Bank 
    {
        public string Name { get; set; }

        public Bank(string name,Stock stock)
        {
            this.Name = name;
            stock.Notify += this.Update;
        }

        public void Update(object sender, StockInfoEventArgs info)
        {
            Console.WriteLine(
                info.Euro > 40 ? "Банк {0} продает евро;  Курс евро: {1}" : "Банк {0} покупает евро;  Курс евро: {1}",
                this.Name,
                info.Euro);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {
        private StockInfoEventArgs stocksInfo;


        public Stock()
        {
            stocksInfo = new StockInfoEventArgs();
        }

        public StockInfoEventArgs Info => this.stocksInfo;

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            this.NotyfyMethod();
        }

        private void NotyfyMethod()
        {
            EventHandler<StockInfoEventArgs> handler = Notify;

            if (handler != null)
            {
                handler(this, this.stocksInfo);
            }
        }

        public event EventHandler<StockInfoEventArgs> Notify;
    }
}

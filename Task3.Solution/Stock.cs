using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {
        public Stock()
        {
            this.Info = new StockInfoEventArgs();
        }

        public StockInfoEventArgs Info { get; set; }

        public void Market()
        {
            Random rnd = new Random();
            this.Info.USD = rnd.Next(20, 40);
            this.Info.Euro = rnd.Next(30, 50);
            this.NotyfyMethod();
        }

        private void NotyfyMethod()
        {
            var handler = this.Notify;

            handler?.Invoke(this, this.Info);
        }

        public virtual event EventHandler<StockInfoEventArgs> Notify;
    }
}

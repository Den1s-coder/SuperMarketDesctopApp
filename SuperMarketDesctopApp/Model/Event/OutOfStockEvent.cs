using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDesctopApp.Model.Event
{
    public class OutOfStockEvent
    {
        public string ProductName { get; }
        public int AvailableStock { get; }

        public OutOfStockEvent(string productName, int availableStock)
        {
            ProductName = productName;
            AvailableStock = availableStock;
        }
    }
}

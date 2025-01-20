using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5taskoop
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount*.005m;
        }

        public void ProcessOrder()
        {
            
        }
    }
}

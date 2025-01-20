using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5taskoop
{
    enum location
    {
        online,instore

    }

    internal class OnlineOrderProcessor : IOrderProcessor
    { 
        
     

    


        public decimal CalculateDiscount(decimal orderAmount)
        {
           return orderAmount* .01m;
        }

        public void ProcessOrder()
        {
          
        }
    }
}

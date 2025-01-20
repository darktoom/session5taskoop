using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5taskoop
{
    internal class Order
    {
        public int OrderId {  get; set; }
      public string customer_name { get; set; }
     public  Decimal OrderAmount {  get; set; }
    public  IOrderProcessor OrderProcessor {  get; set; }
       
        public Order(int OrderId,string customer_name,decimal OrderAmount,IOrderProcessor orderProcessor)     
    {
        this.OrderId = OrderId;
            this.customer_name = customer_name;
            this.OrderAmount = OrderAmount; 
            this.OrderProcessor = orderProcessor;



        }



    }
}

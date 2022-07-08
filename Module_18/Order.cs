using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    public class Order
    {
        public Order(string email, int productId, string productName)
        {
           
            Email = email;
            ProductId = productId;
            ProductName = productName;
        }
        public Order()
        {

        }
        public int OrderId { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}

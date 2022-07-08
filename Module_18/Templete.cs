using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    public class Templete
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Templete(int Id,string email, string firstName, int productId, string productName)

        {
            this.Id = Id;  
            Email = email;
            FirstName = firstName;
            ProductId = productId;
            ProductName = productName;
        }
        public Templete()
        {

        }
    }
}


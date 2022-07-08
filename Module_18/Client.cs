using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    public class Client
    {
        public Client( string firstName, string middleName, string fatherName, string phoneNumber, string email)
        {
            FirstName = firstName;
            MiddleName = middleName;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Client()
        {

        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Exercises
{
    class BankCustomer
    {
        public string FirstName = "Tim";
        public string LastName = "Shao";
        public readonly string CustomerId;
        private static int s_nextCustomerId;

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer()
        {
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

        public BankCustomer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_EX1
{
    internal abstract class Employee : IEmployee
    {

        public int PaymentPerHour { get; set; }
        public string Name { get; set; }

        protected Employee(int paymentPerHour, string name)
        {
            PaymentPerHour = paymentPerHour;
            Name = name;
        }

        public abstract override string? ToString();
        

        public abstract int CaculateSalary();
        public abstract string GetName();

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_EX1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int paymentPerHour, string name) : base(paymentPerHour, name)
        {
        }

        public override int CaculateSalary()
        {
            return 8 * PaymentPerHour ;
        }

        public override string GetName()
        {
            return Name;    
        }

        public override string? ToString()
        {
            return $"FullTimeEmployee: Name: {Name}, Payment Per Hour: {PaymentPerHour}, Salary: {CaculateSalary()}"; ;
        }
    }
}

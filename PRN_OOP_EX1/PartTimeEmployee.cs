using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_OOP_EX1
{
    internal class PartTimeEmplyee : Employee
    {
        public PartTimeEmplyee(int paymentPerHour, string name, int workinghours) : base(paymentPerHour, name)
        {
            WorkingHours = workinghours;
        }

        public int WorkingHours { get; set; }

        

        public override int CaculateSalary()
        {
            return WorkingHours * PaymentPerHour;
        }


        public override string GetName()
        {
            return Name;
        }

        public override string? ToString()
        {

            return $"PartTimeEmplyee: Name: {Name}, Payment Per Hour: {PaymentPerHour}, Salary: {CaculateSalary()}";
        }
    }
}

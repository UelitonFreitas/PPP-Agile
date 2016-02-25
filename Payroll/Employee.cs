using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public abstract class Employee
    {

        private int EmployeeId { get; }
        private string Address { get; }
        private Affiliation Affiliation{get;}
        public PaymentClassification Classification { get; internal set; }
        public PaymentSchendule Schendule { get; internal set; }
        public PaymentMethod Method { get; internal set; }
        public string Name { get; internal set; }

        public abstract bool IsTimeToPay(DateTime time);
        public abstract void Pay();
        public static readonly Employee NULL = new NullEmployee();

        private class NullEmployee : Employee
        {
            public override bool IsTimeToPay(DateTime time)
            {
               return false;
            }

            public override void Pay()
            {

            }
        }

    }
}

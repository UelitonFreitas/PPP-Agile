using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class SalariedClassification : PaymentClassification
    {
        public double Salary { get; }

        public override void CalculePay()
        {
        }
    }
}

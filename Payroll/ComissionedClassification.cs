using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class ComissionedClassification : PaymentClassification
    {
        public double ComissionRate { get; }
        public double Salary { get; }

        public override void CalculePay()
        {
            
        }
    }
}

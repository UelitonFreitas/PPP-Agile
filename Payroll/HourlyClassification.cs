using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class HourlyClassification : PaymentClassification
    {
        public double HourlyRate { get; }

        public override void CalculePay()
        {
            
        }
    }
}

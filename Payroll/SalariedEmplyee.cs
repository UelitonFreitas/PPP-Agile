using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class SalariedEmplyee : Employee
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

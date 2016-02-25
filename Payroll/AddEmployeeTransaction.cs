using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class AddEmployeeTransaction : Transaction
    {
        private int employeeId;
        private string name;
        private string address;

        public AddEmployeeTransaction(int employeeId, string name, string address)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.address = address;
        }

        public void Execute()
        {
            
        }
    }
}

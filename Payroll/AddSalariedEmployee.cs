namespace Payroll
{
    internal class AddSalariedEmployee : AddEmployeeTransaction
    {
        private double value;

        public AddSalariedEmployee(int employeeId, string name, string address, double value) : base(employeeId, name, address)
        {
            this.value = value;
        }
    }
}
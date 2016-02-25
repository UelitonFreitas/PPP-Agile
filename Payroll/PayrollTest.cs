using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payroll
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void TestAddSalariedEmployee()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.0);
            t.Execute();

            Employee employee = PayrollDataBase.GetEmployee(empId);
            Assert.AreEqual("Bob", employee.Name);

            PaymentClassification pc = employee.Classification;
            Assert.IsTrue(pc is SalariedClassification);

            SalariedClassification sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary, .001);

            PaymentSchendule ps = employee.Schendule;
            Assert.IsTrue(ps is MonthlySchendule);

            PaymentMethod pm = employee.Method;
            Assert.IsTrue(pm is HoldMethod);
        }
    }
}

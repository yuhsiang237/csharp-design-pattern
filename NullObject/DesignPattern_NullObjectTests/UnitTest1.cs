using DesignPattern_NullObject;
using NUnit.Framework;
using System;

namespace DesignPattern_NullObjectTests
{
    public class Tests
    {

        [Test]
        public void TestNuLL()
        {
            EmployeeAbstract e = DB.GetEmployee();
            if (e.IsTimeToPay(new DateTime()))
            {
                Assert.Fail();
            }
            Assert.AreSame(EmployeeAbstract.NULL, e);
        }
    }
}
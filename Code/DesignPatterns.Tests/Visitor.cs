using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class Visitor
    {
        [TestMethod]
        public void DoctorIsValid()
        {
            var dr = new Doctor();

            Assert.IsTrue(dr.Validate(new Validators()));
        }
    }
}

using System;
using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Execise.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ShouldBeSingleton()
        {
            //check that when you create a Library instance second time, 
            //you get exactly the same instance as for a very first time
        }

        [TestMethod]
        public void ShouldRegister()
        {
            var lib = Library.GetInstance();
            Assert.IsTrue(lib.Register(new Video(" Walt Disney Pictures", "The Jungle Book", 2016, 10)));
        }
    }
}

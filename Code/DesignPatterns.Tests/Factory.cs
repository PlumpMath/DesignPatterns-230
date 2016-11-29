using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class Factory
    {
        [TestMethod]
        public void TestMethod1()
        {
            var store = new BookStore();
            Assert.IsNotNull(store.GetDistributor());
        }
    }
}

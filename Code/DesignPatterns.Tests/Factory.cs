using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class Factory
    {
        [TestMethod]
        public void NotNullDefaultDistr()
        {
            var store = new BookStore();
            Assert.IsTrue(store.GetDistributor() is EastCostDitributor);
        }

        [TestMethod]
        public void SpecificNonDefaultDistributor()
        {
            var store = new BookStore();
            store.Distributor = new WestCostDitributor();

            Assert.IsTrue(store.GetDistributor() is WestCostDitributor);
        }
    }
}

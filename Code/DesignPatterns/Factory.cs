using System;

namespace DesignPatterns
{
    public interface IDistributor
    {
        void ShipBook();
    }

    public class EastCostDitributor : IDistributor
    {
        private readonly string _cntrName = "East Cost Distributor";

        public void ShipBook()
        {
            Console.WriteLine("Shipped from " + _cntrName);
        }
    }

    public class WestCostDitributor : IDistributor
    {
        private readonly string _cntrName = "West Cost Distributor";

        public void ShipBook()
        {
            Console.WriteLine("Shipped from " + _cntrName);
        }
    }

    public class BookStore
    {
        public IDistributor Distributor { get; set; }
        private readonly IDistributor _defaultDistributor = new EastCostDitributor();
        public IDistributor GetDistributor()
        {
            return Distributor ?? _defaultDistributor;
        }
    }
}

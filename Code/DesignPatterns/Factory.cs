using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

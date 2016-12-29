using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class Person : LibObject
    {
        public string FullName { get; set; }
    }

    public class Customer : Person
    {
        public override LibObject GetRegistrationInfo()
        {
            throw new NotImplementedException();
        }
        
    }
}

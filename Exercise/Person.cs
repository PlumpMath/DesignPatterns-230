using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class Person : ILibObject
    {
        public string FullName { get; set; }
        public abstract bool Register();
    }

    public class Customer : Person
    {
        public override bool Register()
        {

        }
    }
}

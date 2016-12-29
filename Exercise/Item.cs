using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class LibItem : LibObject
    {
        public string Title { get; set; }
    }

    public class Book : LibItem
    {
        public string Author { get; set; }

        public override LibObject GetRegistrationInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class Video : LibItem
    {
        public string Producer { get; set; }

        public override LibObject GetRegistrationInfo()
        {
            throw new NotImplementedException();
        }
    }
}

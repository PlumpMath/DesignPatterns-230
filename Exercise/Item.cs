using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public abstract class LibItem : ILibObject
    {
        public int AmountAvailable { get; }
        public abstract bool Register();
    }

    public class Book : LibItem
    {
        public override bool Register()
        {
            throw new NotImplementedException();
        }
    }

    public class Video : LibItem
    {
        public override bool Register()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class RegistrationRepository
    {
        public static List<string> CustomersList { get; } = null;
        public static List<string> ItemList { get; } = null;

        //implement Register method so it will accept both a Person and an Item
        public static bool Register(ILibObject libObject)
        {
            return libObject.Register();
        }


    }
}

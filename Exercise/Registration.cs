using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class RegistrationRepository
    {
        public static List<LibObject> RegisteredList { get; } = null;

        //implement Register method so it will accept both a Person and an Item
        public static bool Register(LibObject libObject)
        {
            var info = libObject.GetRegistrationInfo();
            if (info != null)
            {
                RegisteredList.Add(info);
                return true;
            }

            return false;
        }


    }
    
    public class RegisteredItem
    {
        public string TitleName { get; set; }
        public string AuthorProducer { get; set; }
        public int AvailableAmount { get; set; }

    }
}

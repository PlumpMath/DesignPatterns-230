using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IRegistarable
    {
        RegisteredObject GetRegistrationInfo();
    }

    public static class RegistrationRepository
    {
        public static List<RegisteredObject> RegisteredList { get; } = null;

        //implement Register method so it will accept both a Person and an Item
        public static bool Register(IRegistarable libObject)
        {
            var info = libObject.GetRegistrationInfo();
            if (info == null) return false;

            info.Id = GetNextAvailableId();
            RegisteredList.Add(info);
            return true;
        }

        private static int GetNextAvailableId()
        {
            return RegisteredList.Count + 1;
        }
    }

    public class RegisteredObject
    {
        public string Info { get; set; }
        public int Id { get; set; }
        public int AvailableAmount { get; set; }
    }
}

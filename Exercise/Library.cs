using System;

namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist

        /////
        private static Library _instance;

        private Library() {}

        public static Library GetInstance()
        {
            return _instance ?? (_instance = new Library());
        }
        
        public bool Register(IRegistarable libObject)
        {
            return RegistrationRepository.Register(libObject);
        }

    }
}

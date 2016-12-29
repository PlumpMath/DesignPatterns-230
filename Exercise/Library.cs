using System;

namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist

        /////
        private Library _instance;
       

        private Library() {}

        public Library GetInstance()
        {
            return _instance ?? (_instance = new Library());
        }


        public bool Register(ILibObject libObject)
        {
            return RegistrationRepository.Register(libObject);
        }

    }
}

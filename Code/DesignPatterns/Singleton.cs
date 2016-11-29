using System;

namespace Singleton
{
    public class SingleObject
    {
        //create an object of SingleObject private 	
        static SingleObject instance = new SingleObject();

        //make the constructor private so that this class cannot be instantiated 	
        private SingleObject() { }

        //Get the only object available 
        public static SingleObject GetInstance() { return instance; }
        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}



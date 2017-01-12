using System;
using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Execise.Tests
{
    [TestClass]
    public class UnitTests
    {
        //test the two calls to library instance return same instance
        [TestMethod]
        public void LibraryShouldBeSingleton()
        {
            //check that when you create a Library instance second time, 
            //you get exactly the same instance as for a very first time
            Assert.IsTrue(ReferenceEquals(Library.GetInstance(), Library.GetInstance()));
        }

        //test that an item was registered
        [TestMethod]
        public void ShouldRegister()
        {
            //check that an item was registered successfully
            Assert.IsTrue(Library.GetInstance().Register(new Customer("Alex B", "386 Broadway")) != -1);

            Assert.IsTrue(Library.GetInstance().Register(new Book(" J. K. Rowling", "Harry Potter", 2016, 10)) != -1);
        }

       
        // NOT FOR EXERCISE
        
        //test the very first id is always 1
        [TestMethod]
        public void FirstIdIsAlwaysOne()
        {
            RegistrationRepository.DeleteAllRegisteredItems();

            var id = Library.GetInstance().Register(new Book(" J. K. Rowling", "Harry Potter", 2016, 10));

            Assert.IsTrue(id == 1);
        }
    }
}

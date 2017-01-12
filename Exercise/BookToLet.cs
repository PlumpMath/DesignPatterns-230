using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    
    public class BookToLet : Item
    {
        private readonly Book _book;

        public string Author { get {return  _book.Author; } set { _book.Author = value; } }

        public bool BorrowOne()
        {
            if (_book.AvailableAmount <= 0) return false;

            _book.AvailableAmount--;
            return true;
        }

        public BookToLet(Book b) : base(b.AvailableAmount, b.YearCreated)
        {
            _book = b;
        }

        public override RegisteredObject GetRegistrationInfo()
        {
            return _book.GetRegistrationInfo();
        }
    }
}

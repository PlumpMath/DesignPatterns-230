namespace Exercise
{
    public class BookBorrowable : Book
    {
        private readonly Book _book;

        public bool BorrowOne()
        {
            if (_book.AvailableAmount <= 0) return false;

            _book.AvailableAmount--;
            return true;
        }

        new public int AvailableAmount { get { return _book.AvailableAmount; } set { _book.AvailableAmount = value; } }

        public BookBorrowable(Book b) : base(b.Author, b.NameOrTitle, b.YearCreated, b.AvailableAmount)
        {
            _book = b;
        }

        public override RegisteredObject GetRegistrationInfo()
        {
            return _book.GetRegistrationInfo();
        }
    }
}

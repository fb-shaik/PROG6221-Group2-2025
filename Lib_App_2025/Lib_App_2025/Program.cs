namespace Lib_App_2025
{
    public class Book
    {
        // Private fields to store book information
        private string title;
        private string author;
        private bool isBorrowed;

        // Public properties to control access to private fields
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public bool IsBorrowed { get { return isBorrowed; } }

        // Constructor to initialize book details
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isBorrowed = false; // New books are not borrowed by default
        }

        // Method to borrow a book
        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine($"You borrowed '{Title}' by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{Title}' is already borrowed.");
            }
        }

        // Method to return a book
        public void Return()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine($"You returned '{Title}'.");
            }
            else
            {
                Console.WriteLine($"This book was not borrowed.");
            }
        }
    }

    public class Library
    {
        // A list to store books in the library
        private List<Book> books = new List<Book>();

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"'{book.Title}' added to the library.");
        }

        // Method to borrow a book by title
        public void BorrowBook(string title)
        {
            // Find the book in the list
            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            // If book is found, attempt to borrow it
            if (book != null)
                book.Borrow();
            else
                Console.WriteLine($"Book '{title}' not found.");
        }

        // Method to return a book by title
        public void ReturnBook(string title)
        {
            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book != null)
                book.Return();
            else
                Console.WriteLine($"Book '{title}' not found.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new library instance
            Library myLibrary = new Library();

            // Add books to the library
            myLibrary.AddBook(new Book("C# Basics", "John Doe"));
            myLibrary.AddBook(new Book("Learning OOP", "Jane Smith"));

            // Borrow and return books
            myLibrary.BorrowBook("C# Basics");
            myLibrary.ReturnBook("C# Basics");
            myLibrary.BorrowBook("Java Fundamentals"); // This book is not in the library
        }
    }
}

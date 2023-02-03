using System;
using System.Data.SqlClient;

namespace LibraryDBRepository
{
    class LibrarySystem
    {
        static void Main(string[] args)
        {
            // Connection string
            string connectionString = "Data Source=LAPTOP-FGM1NGK3\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            start:
            // Show menu
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. List of Available Books");
            Console.WriteLine("2. Update Loan Status of a Book");
            Console.WriteLine("3. Search Books by Genre");
            Console.WriteLine("4. Search Books by Author");
            Console.WriteLine("5. Add a book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            // Get user's choice
            int choice = int.Parse(Console.ReadLine());
            
            // Execute user's choice
            switch (choice)
            {
                case 1:
                    Library.GetAvailableBooks(connectionString);
                    string tryAgain = Console.ReadLine();
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                case 2:
                    Console.Write("Enter book ID: ");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.Write("Enter loan status (0 = available, 1 = loaned): ");
                    string loanStatus = Console.ReadLine();
                    Library.UpdateLoanStatus(connectionString, bookId, loanStatus);
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                case 3:
                    Console.Write("Enter genre: ");
                    string genre = Console.ReadLine();
                    Library.SearchBooksByGenre(connectionString, genre);
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                case 4:
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Library.SearchBooksByAuthor(connectionString, author);
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                case 5:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter book genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Enter book genre: ");
                    loanStatus = Console.ReadLine();
                    AddBook.AddBookToDB(connectionString, title, author, genre, loanStatus);
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                    goto start;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
            }

            // Wait for user to press a key
            Console.ReadKey();
        }
    }
}
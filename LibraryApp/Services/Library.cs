using System.Data.SqlClient;

class Library
{
    public static void GetAvailableBooks(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT Id, Title, Author, Genre, Loan_Status FROM Books WHERE Loan_Status = 0";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("Book ID\tTitle\tLoan Status");
            while (reader.Read())
            {
                int bookId = reader.GetInt32(0);
                string title = reader.GetString(1);
                string loanStatus = reader.GetString(2);

                Console.WriteLine("{0}\t{1}\t{2}", bookId, title, loanStatus);
            }
        }
    }

    public static void UpdateLoanStatus(string connectionString, int bookId, string loanStatus)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "UPDATE Books SET Loan_Status = @loan_status WHERE Id = @book_id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Loan_Status", loanStatus);
            command.Parameters.AddWithValue("@Id", bookId);
            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine("{0} row(s) affected.", rowsAffected);
        }
    }

    public static void SearchBooksByGenre(string connectionString, string genre)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT Id, Title, Author, Loan_Status FROM books WHERE Genre = @genre";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@genre", genre);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("Book ID\tTitle\tLoan Status");
            while (reader.Read())
            {
                int bookId = reader.GetInt32(0);
                string title = reader.GetString(1);
                string loanStatus = reader.GetString(2);

                Console.WriteLine("{0}\t{1}\t{2}", bookId, title, loanStatus);
            }
        }
    }

    public static void SearchBooksByAuthor(string connectionString, string author)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT Id, Title, Loan_Status FROM books WHERE Author = @author";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@author", author);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("Book ID\tTitle\tLoan Status");
            while (reader.Read())
            {
                int bookId = reader.GetInt32(0);
                string title = reader.GetString(1);
                string loanStatus = reader.GetString(2);

                Console.WriteLine("{0}\t{1}\t{2}", bookId, title, loanStatus);
            }
        }
    }
}

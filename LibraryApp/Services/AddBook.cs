using System.Data.SqlClient;

class AddBook
{
    public static void AddBookToDB(string connectionString, string title, string author, string genre, string loanStatus)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "INSERT INTO Books (Title, Author, Genre, Loan_Status) VALUES (@Title, @Author, @Genre, @LoanStatus)";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Genre", genre);
                command.Parameters.AddWithValue("@LoanStatus", loanStatus);

                command.ExecuteNonQuery();
            }
        }
    }
}
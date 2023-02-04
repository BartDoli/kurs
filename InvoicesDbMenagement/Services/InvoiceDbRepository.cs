using InvoicesDbMenagement.Models;
using System.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;

namespace InvoicesDbMenagement.Services
{
    public class InvoiceDbRepository
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Get list of invoices");
            Console.WriteLine("2. Add an invoice");
            Console.WriteLine();

            Console.Write("Enter option number: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    GetInvoices();
                    Console.ReadLine();
                    Console.Clear();
                    goto start;

                case 2:
                    Console.Write("Enter client company name: ");
                    string clientCompanyName = Console.ReadLine();
                    Console.Write("Enter client NIP: ");
                    string clientNip = Console.ReadLine();
                    Console.Write("Enter user name: ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter user last name: ");
                    string userLastName = Console.ReadLine();
                    Console.Write("Enter amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    AddInvoice(clientCompanyName, clientNip, userName, userLastName, amount);
                    Console.ReadLine();
                    Console.Clear();
                    goto start;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        private static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FGM1NGK3\\SQLEXPRESS;Initial Catalog=InvoiceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM invoices", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        invoices.Add(new Invoice
                        {
                            Id = (int)reader["Id"],
                            SeriesNumber = (string)reader["SeriesNumber"],
                            ClientCompanyName = (string)reader["ClientCompanyName"],
                            ClientNip = (string)reader["ClientNip"],
                            UserName = (string)reader["UserName"],
                            UserLastName = (string)reader["UserLastName"],
                            Amount = (decimal)reader["Amount"]
                        });
                    }
                }
            }
            Console.WriteLine("List of invoices:");
            System.Collections.IList list = invoices;
            for (int i = 0; i < list.Count; i++)
            {
                string invoice = list[i] as string;
                Console.WriteLine(invoice);
            }
            return invoices;
        }

        public static void AddInvoice(string clientCompanyName, string clientNip, string userName, string userLastName, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-FGM1NGK3\\SQLEXPRESS;Initial Catalog=InvoiceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO invoices (ClientCompanyName, ClientNip, UserName, UserLastName, Amount) VALUES (@ClientCompanyName, @ClientNip, @UserName, @UserLastName, @Amount)", connection))
                {
                    command.Parameters.AddWithValue("@ClientCompanyName", clientCompanyName);
                    command.Parameters.AddWithValue("@ClientNip", clientNip);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserLastName", userLastName);
                    command.Parameters.AddWithValue("@Amount", amount);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("{0} row(s) affected.", rowsAffected);
                }
            }
        }
    }
}


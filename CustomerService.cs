using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CustomerDbWinForms
{
    public class CustomerService
    {
        private string connectionString = "Server=localhost;Database=CustomerDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public int CreateCustomer(string firstName, string lastName, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Customers (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Customer> ListCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, FirstName, LastName, Email FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Email = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            return customers;
        }

        public bool UpdateCustomer(int customerId, string newEmail)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Customers SET Email = @Email WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Id", customerId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Customers WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", customerId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
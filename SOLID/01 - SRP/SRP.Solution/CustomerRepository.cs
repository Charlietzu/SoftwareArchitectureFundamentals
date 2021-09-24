using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.Solution
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Customer (NAME, EMAIL CPF, REGISTRATIONDATE) VALUES (@nome, @email, @cpf, @registrationDate))";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("cpf", customer.Cpf);
                cmd.Parameters.AddWithValue("registrationDate", customer.RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System.Data;
using System.Data.SqlClient;

namespace SOLID.DIP.Violation
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
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, REGISTRATION_DATE) VALUES (@name, @email, @cpf, @registrationDate))";

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
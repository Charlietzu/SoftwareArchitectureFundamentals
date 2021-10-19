using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violation
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string AddCustomer()
        {
            if (!Email.Contains("@"))
                return "Customer with invalid email";

            if (CPF.Length != 11)
                return "Customer with invalid CPF";


            using (SqlConnection cn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, REGISTRATIONDATE) VALUES (@nome, @email, @cpf, @registrationDate))";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("registrationDate", RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MailMessage mail = new MailMessage("company@company.com", Email);
            SmtpClient client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome.";
            mail.Body = "Congratulations, you are registered!";
            client.Send(mail);

            return "Successfully registered customer!";
        }
    }
}
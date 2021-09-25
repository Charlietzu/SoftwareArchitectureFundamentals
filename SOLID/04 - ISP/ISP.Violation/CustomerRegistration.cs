namespace SOLID.ISP.Violation
{
    public class CustomerRegistration : IRegistration
    {
        public void ValidateData()
        {
            // Validate CPF, Email
        }

        public void SaveDatabase()
        {
            // Insert in Customer table
        }

        public void SendEmail()
        {
            // Send email to the customer
        }
    }
}
using SOLID.ISP.Solution.Interfaces;

namespace SOLID.ISP.Solution
{
    public class CustomerRegistration : ICustomerRegistration
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
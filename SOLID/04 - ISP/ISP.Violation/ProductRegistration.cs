using System;

namespace SOLID.ISP.Violation
{
    public class ProductRegistartion : IRegistration
    {
        public void ValidateData()
        {
            // Validate value
        }

        public void SaveDatabase()
        {
            // Insert in Product table
        }

        public void SendEmail()
        {
            // Product does not have e-mail, what do I do now???
            throw new NotImplementedException("This method is useless");
        }
    }
}
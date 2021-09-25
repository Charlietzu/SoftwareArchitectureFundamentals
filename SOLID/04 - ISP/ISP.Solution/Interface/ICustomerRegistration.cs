namespace SOLID.ISP.Solution.Interfaces
{
    public interface ICustomerRegistration : IRegistration
    {
        void ValidateData();
        void SendEmail();
    }
}
namespace SOLID.ISP.Violation
{
    public interface IRegistration
    {
        void ValidateData();
        void SaveDatabase();
        void SendEmail();
    }
}
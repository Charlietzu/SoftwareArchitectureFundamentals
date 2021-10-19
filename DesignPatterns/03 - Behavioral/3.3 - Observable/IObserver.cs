namespace DesignPatterns
{
    // Observer
    public interface IObserver
    {
        string Name { get; }
        void Notificate(Investment investment);
    }
}
namespace Website.DAL.Interfaces
{
    using Entities;

    public interface IUnitOfWork : System.IDisposable
    {
        IRepository<Message> Messages { get; }
    }
}

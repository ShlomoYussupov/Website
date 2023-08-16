namespace Website.DAL.Interfaces
{
    using Entities;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        T Get(int id);
        void Insert(Message entity);
        Task InsertAsync(Message entity);
        void Update(Message entity);
        Task UpdateAsync(Message entity);
        void Delete(int id);
        Task DeleteAsync(Message entity);
        System.Collections.Generic.IEnumerable<T> ReadAll();
        Task<System.Collections.Generic.List<Message>> ReadAllAsync();
    }
}

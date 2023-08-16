
namespace Website.DAL.Repositories
{
    using EF;
    using System.Linq;
    using Entities;
    using Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Entity;

    public class MessageRepository : IRepository<Message>
    {
        private readonly DataContext db;

        public MessageRepository(DataContext db)
        {
            this.db = db;
        }

        public void Delete(int id)
        {
            db.Messages.Remove(Get(id));
            db.SaveChanges();
        }

        public async Task DeleteAsync(Message entity)
        {
            db.Messages.Remove(entity:entity);
            await db.SaveChangesAsync();
        }

        public Message Get(int id)
        {
            return db.Messages.Find(id);
        }

        public void Insert(Message entity)
        {
            db.Messages.Add((entity));
            db.SaveChanges();
        }

        public async Task InsertAsync(Message entity)
        {
            db.Messages.Remove(entity);
            await db.SaveChangesAsync();
        }

        public IEnumerable<Message> ReadAll()
        {
            return db.Messages;
        }

        public async Task<List<Message>> ReadAllAsync()
        {
            return await (from a in db.Messages select a).ToListAsync();
        }

        public void Update(Message entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task UpdateAsync(Message entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}

using System;

namespace Website.DAL.UOW
{
    using Website.DAL.EF;
    using Interfaces;
    using Entities;
    using Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext Db;
        private MessageRepository msgRepo;

        public UnitOfWork(string connStr)
        {
            Db = new DataContext(connStr);
        }

        public IRepository<Message> Messages
        {
            get
            {
                if (msgRepo == null)
                    msgRepo = new MessageRepository(Db);
                return msgRepo;
            }
        }

        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    Db.Dispose();
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

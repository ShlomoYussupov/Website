namespace Website.DAL.EF
{
    using Entities;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext(string connection) : base(connection)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}

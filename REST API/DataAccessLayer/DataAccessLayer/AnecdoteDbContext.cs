using DataAccessLayer.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLayer
{
    public class AnecdoteDbContext : DbContext, IDbContext
    {
        public AnecdoteDbContext() : base("AnecdoteDB") //name=Conn
        {
            Database.SetInitializer<AnecdoteDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Anecdote>().HasRequired(a => a.Detail).WithRequiredPrincipal(d => d.Anectode);
            base.OnModelCreating(modelBuilder);
        }

        DbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return Set<TEntity>();
        }
    }

    /*public class AnecdoteDBInitializer : DropCreateDatabaseAlways<AnecdoteDbContext>
    {
        protected override void Seed(AnecdoteDbContext context)
        {
            Random random;
            foreach (Anecdote anecdote in InitialDataList.Anectodes)
            {
                random = new Random();
                Detail detail = new Detail
                {
                    LikedCount = random.Next(20, 40),
                    SavedCount = random.Next(10, 30),
                    SharedCount = random.Next(20, 40),
                    ShowedCount = random.Next(60, 100)
                };
                anecdote.Detail = detail;
                context.Set<Anecdote>().Add(anecdote);

            }
            base.Seed(context);
        }
    }*/
}

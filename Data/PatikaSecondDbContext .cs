using FirstRelation.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace FirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options) { } // we defined the options for the appsettng.json setting

        public DbSet<Post> Posts { get; set; } // we defined the Posts tables for the our DB
        public DbSet<User> Users { get; set; } //we defined the Users tables for the our DB

        //ıt is for the foriegn key navaigtation property
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User) 
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }

    }
}

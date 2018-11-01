using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestTask.Data.Models;

namespace TestTask.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        #region Constructor

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Constructor

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasMany(u => u.Tags).WithOne(i => i.User);

            modelBuilder.Entity<Tag>().ToTable("Quizzes");
            modelBuilder.Entity<Tag>().Property(i => i.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tag>().HasOne(i => i.User).WithMany(u => u.Tags);
        }

        #endregion Methods
    }
}
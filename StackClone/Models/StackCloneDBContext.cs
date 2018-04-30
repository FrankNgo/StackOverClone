using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StackClone.Models
{
    public class StackCloneDBContext : DbContext
    {
        public StackCloneDBContext()
        {
        }

        //public StackCloneDBContext(DbContextOptions options) : base(options)
        //{

        //}



        public DbSet<Answer> Answers { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=StackClone;uid=root;pwd=root;");
        }

        public StackCloneDBContext(DbContextOptions<StackCloneDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    
    }

}
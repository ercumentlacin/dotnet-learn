using Microsoft.EntityFrameworkCore;

namespace LMS.Data.Entities;

public class LMSDBContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("MyLMSDatabase");
    }
}
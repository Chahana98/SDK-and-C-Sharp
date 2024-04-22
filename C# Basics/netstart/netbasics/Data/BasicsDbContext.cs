using Microsoft.EntityFrameworkCore;
public class BasicsDbContext: DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=College.db");
    }
}
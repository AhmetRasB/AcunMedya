using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Application> Applications { get; set; } // Düzeltilmiş
    public DbSet<Bootcamp> Bootcamps { get; set; }
    public DbSet<Blacklist> Blacklists { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Model konfigürasyonları burada yapılır
    }
}
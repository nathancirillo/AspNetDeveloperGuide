using Microsoft.EntityFrameworkCore;
public class AppContext : DbContext
{
  public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity => {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
          entity.HasIndex(e => e.Name).IsUnique();
          entity.Property(x => x.Price).HasColumnType("decimal(18,2)");
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer
        (
            "Server=DESKTOP-TN3UTGK\\SQLEXPRESS;Database=EFCoreCrudDB;Trusted_Connection=True;"
        );
    }
}
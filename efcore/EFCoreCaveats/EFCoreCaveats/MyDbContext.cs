using Microsoft.EntityFrameworkCore;

namespace EFCoreCaveats;

public class MyDbContext : DbContext
{
    public DbSet<ParentEntity> Parents { get; set; } = null!;
    public DbSet<ChildEntity> Children { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChildEntity>(entity =>
        {
            entity.HasOne(ce => ce.Parent).WithMany(cp => cp.Children).HasForeignKey(ce => ce.ParentID);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=localhost;Database=ormcaveats;User Id=sa;Password=abcd1234ABCD;");
    }
}

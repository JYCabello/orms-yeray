using Microsoft.EntityFrameworkCore;

namespace EFCoreCaveats;

public class MyDbContext : DbContext
{
    public DbSet<ParentEntity> Parents { get; set; } = null!;
    public DbSet<ChildEntity> Children { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ParentEntity>(entity =>
        {
            entity.HasMany<ChildEntity>().WithOne().HasForeignKey(ce => ce.ParentID);
        });

        modelBuilder.Entity<ChildEntity>(entity =>
        {
            entity.HasOne<ParentEntity>().WithMany().HasForeignKey(ce => ce.ParentID);
        });
    }
}

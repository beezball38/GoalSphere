using GoalSettingApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoalSettingApp.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<Goal> Goals => Set<Goal>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Goal>(entity =>
        {
            entity.Property(e => e.Title).IsRequired();
        });
    }
}


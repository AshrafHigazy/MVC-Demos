global using Demo.DataAccess.Models;
global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Demo.DataAccess.Context;
public class CompanyDbContext(DbContextOptions<CompanyDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{

    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Ignore<IdentityUserToken<string>>();
        modelBuilder.Entity<ApplicationUser>(builder =>
        {
            builder.Property(u => u.FirstName)
            .HasMaxLength(256);
            builder.Property(u => u.LastName)
            .HasMaxLength(256);
        });


        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
    }


}

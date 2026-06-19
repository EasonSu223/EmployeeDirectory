using EmployeeDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee { EmployeeId = 1, Name = "Henry Baird",     Email = "henry@123.com",    Role = "Full Stack Developer" },
            new Employee { EmployeeId = 2, Name = "Frank Hook",      Email = "frank@123.com",    Role = "Project Manager" },
            new Employee { EmployeeId = 3, Name = "Jennifer Carter", Email = "jennifer@123.com", Role = "UI/UX Designer" },
            new Employee { EmployeeId = 4, Name = "Megan Elmore",    Email = "megn@123.com",     Role = "Team Leader & Web Developer" },
            new Employee { EmployeeId = 5, Name = "Alexis Clarke",   Email = "alex@123.com",     Role = "Backend Developer" },
            new Employee { EmployeeId = 6, Name = "Nancy Martino",   Email = "nancy@123.com",    Role = "Team Leader & HR" }
        );
    }
}
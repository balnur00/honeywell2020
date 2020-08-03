using DbAppTask2.Models;
using System.Data.Entity;

public class EmployeeContext : DbContext
{
    public EmployeeContext() : base("DefaultConnection")
    {

    }
    public DbSet<Employee> Employees { get; set; }
}
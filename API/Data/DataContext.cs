using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    //constructor
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    //AppUser: entity name of DbSet
    //Users: name of the table in the database
    public DbSet<AppUser> Users { get; set; }
}

using Microsoft.EntityFrameworkCore;
using newt.api.Persistence.Entities;

namespace newt.api.Persistence;

public class NewtContext : DbContext
{
    public NewtContext(DbContextOptions<NewtContext> options) : base(options)
    {
        
    }

    public DbSet<Book>? Books { get; set; }
    public DbSet<Library>? Libraries { get; set; }
    public DbSet<Category>? Categories { get; set; }
}
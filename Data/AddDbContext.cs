using Microsoft.EntityFrameworkCore;
using mvc_dotnet.Models;

namespace mvc_dotnet.Data;

public class AddDbContext : DbContext
{
    public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}

    

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using UrlShortaner.Application.Common.Interfaces;

namespace UrlShortaner.Infratructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Domain.Entities.UrlShortaner> TodoLists => Set<Domain.Entities.UrlShortaner>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

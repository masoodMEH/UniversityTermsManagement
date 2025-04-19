using Microsoft.EntityFrameworkCore;
using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.StateEntity;
using TermsManagement.Infrastructure.Ef.Mappings;

namespace TermsManagement.Infrastructure.Ef;

public class TermsManagement_Context(DbContextOptions<TermsManagement_Context> options) : DbContext(options)
{
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new StateMapping());
        modelBuilder.ApplyConfiguration(new CityMapping());
    }
}

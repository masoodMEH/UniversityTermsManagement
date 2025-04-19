using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TermsManagement.Domain.Repository;
using TermsManagement.Infrastructure.Ef.RepositoriesImpl;

namespace TermsManagement.Infrastructure.Ef;

public class TermsInfrastructure_Bootstrapper
{
    public static void Config(IServiceCollection services, string connectionString)
    {
        services.AddTransient<IStateRepository, StateRepository>();
        services.AddTransient<ICityRepository, CityRepository>();

        services.AddDbContext<TermsManagement_Context>(ctx =>
        {
            ctx.UseSqlServer(connectionString);
        });
    }
}
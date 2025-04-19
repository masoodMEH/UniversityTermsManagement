using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TermsManagement.Application.Services;
using TermsManagement.Domain.Repository;
using TermsManagement.Infrastructure.Ef;
using TermsManagement.Infrastructure.Ef.RepositoriesImpl;

namespace TermsManagement.Query;

public class Terms_Bootstrapper
{
    public static void Config(IServiceCollection services, string connectionString)
    {
        TermsInfrastructure_Bootstrapper.Config(services, connectionString);
        TermsApplicatiom_Bootstrapper.Config(services);
    }
} 
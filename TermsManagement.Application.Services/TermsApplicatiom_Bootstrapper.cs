using Microsoft.Extensions.DependencyInjection;
using TermsManagement.Application.Contract.CityApplication;
using TermsManagement.Application.Contract.StateApplication;

namespace TermsManagement.Application.Services;

public class TermsApplicatiom_Bootstrapper
{
    public static void Config(IServiceCollection services)
    {
        services.AddTransient<IStateApplication, StateApplication>();
        services.AddTransient<ICityApplication, CityApplication>();
    }
}
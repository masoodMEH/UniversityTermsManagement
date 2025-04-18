using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

public class CityRepository : GenericRepository<int, City>, ICityRepository
{
}

using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

public class CityRepository : GenericRepository<int, City>, ICityRepository
{
    private readonly TermsManagement_Context _context;

    public CityRepository(TermsManagement_Context context) : base(context)
    {
        _context = context;
    }
}

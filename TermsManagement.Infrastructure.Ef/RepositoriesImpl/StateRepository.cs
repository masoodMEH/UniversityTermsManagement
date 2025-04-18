using TermsManagement.Domain.Repository;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

public class StateRepository : GenericRepository<int, State>, IStateRepository
{
    private readonly TermsManagement_Context _context;
    public StateRepository(TermsManagement_Context context) : base(context)
    {
        _context = context;
    }
}

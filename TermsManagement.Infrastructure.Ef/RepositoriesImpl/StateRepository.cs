using TermsManagement.Domain.Repository;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

public class StateRepository : GenericRepository<int, State>, IStateRepository
{
}

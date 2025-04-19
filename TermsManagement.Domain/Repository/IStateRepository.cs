using TermsManagement.Application.Contract.StateApplication;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Domain.Repository;

public interface IStateRepository : IGenericRepository<int, State>
{
    List<StateViewModel>? GetAllStateViewModel();
    EditStateModel GetStateForEdit(int id);
}

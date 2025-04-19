using TermsManagement.Application.Contract.StateApplication;
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

    public List<StateViewModel>? GetAllStateViewModel()
    {
        return GetAllQuery().Select(key => new StateViewModel
        {
            CreateDate = key.CreateDate.ToString(),
            Id = key.Id,
            Title = key.Title 
        }).ToList();
    }

    public EditStateModel GetStateForEdit(int id)
    {
        var state = GetById(id);
        return new()
        {
            Id = state.Id,
            Title = state.Title,
        };
    }
}
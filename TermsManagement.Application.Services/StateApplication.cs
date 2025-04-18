using TermsManagement.Application.Contract.StateApplication;
using TermsManagement.Domain.Repository;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Application.Services;

public class StateApplication : IStateApplication
{
    private readonly IStateRepository? _stateRepository;

    public StateApplication(IStateRepository? stateRepository)
    {
        _stateRepository = stateRepository;
    }

    public bool Create(CreateStateModel command)
    {
        State state = new(command.Title!);
        return _stateRepository!.Create(state);
    }

    public bool Edit(EditStateModel command)
    {
        var state = _stateRepository?.GetById(command.Id);
        state!.Edit(command.Title!);
        return _stateRepository!.Save();
    }

    public bool ExistTitleForCreate(string title) =>
        _stateRepository!.ExistBy(key => key.Title == title);

    public bool ExistTitleForEdit(string title, int id) =>
        _stateRepository!.ExistBy(key => key.Title == title && key.Id != id);

    public List<StateViewModel>? GetAll() =>
        _stateRepository?.GetAll().Select(key => new StateViewModel
        {
            Id = key.Id,
            CreateDate = key.CreateDate.ToString(),
            Title = key.Title
        }).ToList();

    public EditStateModel GetStateForEdit(int id)
    {
        var state = _stateRepository.GetById(id);
        return new()
        {
            Id = state.Id,
            Title = state.Title
        };
    }
}

﻿using TermsManagement.Application.Contract.StateApplication;
using TermsManagement.Domain.Repository;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Application.Services;

internal class StateApplication : IStateApplication
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
        _stateRepository?.GetAllStateViewModel ();

    public EditStateModel GetStateForEdit(int id)
    {
        return _stateRepository?.GetStateForEdit(id);
    }
}

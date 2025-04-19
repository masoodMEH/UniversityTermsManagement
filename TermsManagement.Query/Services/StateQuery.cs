using Microsoft.EntityFrameworkCore;
using TermsManagement.Application.Contract.StateQuery;
using TermsManagement.Infrastructure.Ef;

namespace TermsManagement.Query.Services;

internal class StateQuery : IStateQuery
{

    private readonly TermsManagement_Context Terms_Context;

    public StateQuery(TermsManagement_Context terms_Context)
    {
        Terms_Context = terms_Context;
    }

    public List<StateQueryModel> GetStateWithCity() =>
        Terms_Context.States.Include(model => model.Cities).Select(Model => new StateQueryModel
        {
            Name = Model.Title,
            Cities = Model.Cities.Select(c => new CityQueryModel
            {
                CityCode = c.Id,
                Name = c.Title
            }).ToList()
        }).ToList();


}
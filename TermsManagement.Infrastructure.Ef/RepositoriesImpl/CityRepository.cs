using TermsManagement.Application.Contract.CityApplication;
using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Infrastructure.Ef.RepositoriesImpl;

internal class CityRepository : GenericRepository<int, City>, ICityRepository
{
    private readonly TermsManagement_Context _context;

    public CityRepository(TermsManagement_Context context) : base(context)
    {
        _context = context;
    }

    public List<CityViewModel> GetAllForState(int stateId)
    {
        return GetAllByQuery(key => key.StateId == stateId).Select(key => new CityViewModel
        {
            Id = key.Id,
        }).ToList();
    }

    public EditCityModel GetCityForEdit(int id)
    {
        var city = GetById(id);
        return new()
        {
            Id = city.Id,
            Status = city.Status,
            Title = city.Title
        };
    }
}
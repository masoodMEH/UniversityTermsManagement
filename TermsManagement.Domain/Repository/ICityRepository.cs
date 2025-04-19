using TermsManagement.Application.Contract.CityApplication;
using TermsManagement.Domain.CityEntity;

namespace TermsManagement.Domain.Repository;

public interface ICityRepository : IGenericRepository<int, City>
{
    List<CityViewModel> GetAllForState(int stateId);
    EditCityModel GetCityForEdit(int id);
}

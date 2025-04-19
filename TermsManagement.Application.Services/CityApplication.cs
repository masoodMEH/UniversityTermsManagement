using _Utilities.Enums;
using TermsManagement.Application.Contract.CityApplication;
using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Application.Services;

 internal class CityApplication : ICityApplication
{
    private readonly ICityRepository? _cityRepository;

    public CityApplication(ICityRepository? cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public bool Create(CreateCityModel command)
    {
        City city = new(command.StateId, command.Title!,command.Status);
        return _cityRepository!.Create(city);
    }


    public bool Edit(EditCityModel command)
    {
        var city = _cityRepository!.GetById(command.Id);
        city.Edit(command.Title!,command.Status);
        return _cityRepository.Save();
    }

    public bool ExistTitleForCreate(string title, int stateId) =>
        _cityRepository!.ExistBy(key => key.Title == title && key.StateId == stateId);

    public bool ExistTitleForEdit(string title, int id, int stateId) =>
        _cityRepository!.ExistBy(key => key.Title == title && key.StateId == stateId && key.Id != id);

    public List<CityViewModel> GetAllForState(int stateId) =>
        _cityRepository.GetAllForState(stateId);

    public EditCityModel GetCityForEdit(int id)=>
        _cityRepository!.GetCityForEdit (id);
}

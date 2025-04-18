using TermsManagement.Application.Contract.CityApplication;
using TermsManagement.Domain.CityEntity;
using TermsManagement.Domain.Repository;

namespace TermsManagement.Application.Services;

public class CityApplication : ICityApplication
{
    private readonly ICityRepository? _cityRepository;

    public bool Create(CreateCityModel command)
    {
        City city = new(command.StateId, command.Title!);
        return _cityRepository!.Create(city);
    }


    public bool Edit(CreateCityModel command)
    {
        var city = _cityRepository!.GetById(command.StateId);
        city.Edit(command.Title!);
        return _cityRepository.Save();
    }

    public bool ExistTitleForCreate(string title, int stateId) =>
        _cityRepository!.ExistBy(key => key.Title == title && key.StateId == stateId);

    public bool ExistTitleForEdit(string title, int id, int stateId) =>
        _cityRepository!.ExistBy(key => key.Title == title && key.StateId == stateId && key.Id != id);

    public List<CityViewModel> GetAllForState(int stateId) =>
        _cityRepository!.GetAllBy(c => c.StateId == stateId).Select(c => new CityViewModel
        {
            Id = c.Id,
            Center = c.Center,
            CreateDate = c.CreateDate.ToString(),
            Tehran = c.Tehran,
            Title = c.Title,
        }).ToList();

    public EditCityModel GetCityForEdit(int id)
    {
        var city = _cityRepository?.GetById(id);
        return new()
        {
            Id = city.Id,
            Title = city.Title,
        };
    }
}

namespace TermsManagement.Application.Contract.CityApplication;

public interface ICityApplication
{
    bool Create(CreateCityModel Command);
    bool Edit(EditCityModel Command);
    bool ExistTitleForCreate(string title, int stateId);
    bool ExistTitleForEdit(string title, int id, int stateId);
    EditCityModel GetCityForEdit(int id);
    List<CityViewModel> GetAllForState(int stateId);
}

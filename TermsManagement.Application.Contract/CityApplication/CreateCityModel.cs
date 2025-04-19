using _Utilities.Enums;

namespace TermsManagement.Application.Contract.CityApplication;

public abstract class CreateCityModel
{
    public int StateId { get; set; }
    public string? Title { get; set; }
    public CityStatus Status { get; set; }
}

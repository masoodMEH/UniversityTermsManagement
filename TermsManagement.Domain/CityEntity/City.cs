using _Utilities.Enums;
using TermsManagement.Domain.Common;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Domain.CityEntity;

public class City : BaseEntity<int>
{
    public int StateId { get; private set; }
    public string? Title { get; private set; }
    public CityStatus Status { get; private set; }
    public State? State { get; private set; }

    public City(int stateId, string title,CityStatus status)
    {
        stateId = StateId;
        title = Title!;
        Status = status;
    }

    public void Edit(string title,CityStatus status)
    {
        title = Title!;
        status = Status;
    }

    public void IsTehran()
    {
        Status = CityStatus.تهران;
    }

    public void IsCenter()
    {
        Status = CityStatus.مرکز_استان;
    }

    public void IsNotCenterOrTehran()
    {
        Status = CityStatus.شهرستان_معمولی;
    }
}

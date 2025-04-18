using TermsManagement.Domain.Common;
using TermsManagement.Domain.StateEntity;

namespace TermsManagement.Domain.CityEntity;

public class City : BaseEntity<int>
{
    public int StateId { get; private set; }
    public State? State { get; private set; }
    public bool Tehran { get; private set; }
    public bool Center { get; private set; }
    public string? Title { get; private set; }

    public City(int stateId, string title)
    {
        stateId = StateId;
        title = Title!;
        Tehran = false;
        Center = false;
    }

    public void Edit(string title)
    {
        title = Title!;
    }

    public void IsTehran()
    {
        Tehran = true;
        Center = false;
    }

    public void IsCenter()
    {
        Center = true;
        Tehran = false;
    }

    public void IsNotCenterOrTehran()
    {
        Tehran = false;
        Center = false;
    }
}

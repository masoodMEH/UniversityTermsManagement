namespace TermsManagement.Application.Contract.StateQuery;

public interface IStateQuery
{
    List<StateQueryModel> GetStateWithCity();
}
namespace TermsManagement.Application.Contract.StateApplication;

public interface IStateApplication
{
    bool Create(CreateStateModel Command);
    bool Edit(EditStateModel Command);
    List<StateViewModel> GetAll();
    EditStateModel GetStateForEdit(int id);
    bool ExistTitleForCreate(string title);
    bool ExistTitleForEdit(string title, int id);

}

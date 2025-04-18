namespace TermsManagement.Domain.Common;

public class BaseEntity<Tkey>
{
    public Tkey Id { get; private set; }
    public DateTime? CreateDate { get; private set; }

    public BaseEntity()
    {
        CreateDate = DateTime.Now;
    }
}

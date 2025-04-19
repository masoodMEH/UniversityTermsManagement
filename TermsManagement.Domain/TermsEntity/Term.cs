namespace TermsManagement.Domain.TermsEntity;

public class Term
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }

    // navigation properties
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
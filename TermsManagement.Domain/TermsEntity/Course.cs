namespace TermsManagement.Domain.TermsEntity;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Units { get; set; }

    // navigation properties
    public int TermId { get; set; }
    public Term Term { get; set; } = null!;

    public int? TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
}
namespace TermsManagement.Domain.TermsEntity;

public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    // navigation properties
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
namespace entity_library;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Student> Students { get; set; } = new();

    public List<Activity> Activities { get; set; } = new();
}
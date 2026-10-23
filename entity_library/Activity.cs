namespace entity_library;

public class Activity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    
    // Relación con el enum
    public TypeActivity TypeActivity { get; set; }
}
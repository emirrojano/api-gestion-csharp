namespace entity_library;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    
    // Relación: Un equipo tiene de 1 a muchos jugadores
    public List<Player> Players { get; set; } = new();
}
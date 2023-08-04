namespace OceanicaAPI.Models;

public class Vessel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public EType Type { get; set; }
    public DateTime BuildAt { get; set; }
    public virtual ICollection<Departament> Departaments { get; set; }
    public string? PhotoFileName { get; set; }
}

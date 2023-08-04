using OceanicaAPI.Models;

namespace OceanicaAPI;

public class ReadVesselDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public EType Type { get; set; }
    public DateOnly BuildAt { get; set; }
    public ICollection<Departament> Departaments { get; set; }
    public string PhotoFileName { get; set; }
}
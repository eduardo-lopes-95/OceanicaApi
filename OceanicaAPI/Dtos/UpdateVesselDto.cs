using OceanicaAPI.Models;

namespace OceanicaAPI;

public class UpdateVesselDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public EType Type { get; set; }
    public DateTime BuildAt { get; set; }
}
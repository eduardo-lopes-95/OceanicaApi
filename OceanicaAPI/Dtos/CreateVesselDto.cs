using OceanicaAPI.Models;

namespace OceanicaAPI;

public class CreateVesselDto
{
    public string Nome { get; set; }
    public EType Type { get; set; }
    public DateTime BuildAt { get; set; }

}
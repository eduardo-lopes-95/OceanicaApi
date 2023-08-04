using OceanicaAPI.Models;

namespace OceanicaAPI;

public class CreateDepartamentDto
{
    public int VesselId { get; set; }
    public string Nome { get; set; }
}
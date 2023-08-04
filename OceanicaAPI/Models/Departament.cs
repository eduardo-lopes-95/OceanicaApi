namespace OceanicaAPI.Models;

public class Departament
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int VesselId { get; set; }
    public virtual Vessel Vessel { get; set; }
    public virtual ICollection<Crew> Crew { get; set; }
}

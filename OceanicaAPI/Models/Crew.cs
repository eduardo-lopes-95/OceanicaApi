namespace OceanicaAPI.Models;

public class Crew
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int DepartamentId { get; set; }
    public virtual Departament Departament { get; set; }
}

using Microsoft.EntityFrameworkCore;
using OceanicaAPI.Models;

namespace OceanicaAPI.Data;

public class OceanicaContext : DbContext
{
    public OceanicaContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Vessel> Vessels { get; set; }
    public DbSet<Departament> Departaments { get; set; }
    public DbSet<Crew> Crews { get; set; }
}

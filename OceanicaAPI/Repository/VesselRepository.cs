using OceanicaAPI.Data;
using OceanicaAPI.Models;
using OceanicaAPI.Repository.Abstract;

namespace OceanicaAPI.Repository;

public class VesselRepository : IRepository<Vessel>
{
    public OceanicaContext Context;

    public VesselRepository(OceanicaContext context)
    {
        Context = context;
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
        Context.Vessels.Remove(entity);
    }

    public ICollection<Vessel> GetAll(int skip, int take)
    {
        return Context.Vessels.Skip(skip).Take(take).ToList();
    }

    public Vessel GetById(int id)
    {
        return Context.Vessels.Find(id);
    }

    public Vessel Insert(Vessel entity)
    {
        Context.Vessels.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public Vessel Update(Vessel entity)
    {
        var entityFound = Context.Vessels.Find(entity.Id);
        if (entityFound == null)
            return null;

        Context.Entry(entityFound).CurrentValues.SetValues(entity);

        Context.SaveChangesAsync();
        return entityFound;
    }
}

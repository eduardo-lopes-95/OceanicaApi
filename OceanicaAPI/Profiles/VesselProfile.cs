using AutoMapper;
using OceanicaAPI.Models;

namespace OceanicaAPI.Profiles;

public class VesselProfile : Profile
{
    public VesselProfile()
    {
        CreateMap<CreateVesselDto, Vessel>().ReverseMap();
        CreateMap<UpdateVesselDto, Vessel>().ReverseMap();
        CreateMap<ReadVesselDto, Vessel>().ReverseMap();
    }
}

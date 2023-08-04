using AutoMapper;
using OceanicaAPI.Models;

namespace OceanicaAPI.Profiles;

public class DepartamentProfile : Profile
{
    public DepartamentProfile()
    {
        CreateMap<CreateDepartamentDto, Departament>().ReverseMap();
        CreateMap<UpdateDepartamentDto, Departament>().ReverseMap();
    }
}

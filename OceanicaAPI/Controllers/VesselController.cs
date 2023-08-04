using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OceanicaAPI.Models;
using OceanicaAPI.Repository.Abstract;

namespace OceanicaAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class VesselController : ControllerBase
{
    public IMapper Mapper;
    public IRepository<Vessel> VesselRepository;

    public VesselController(IRepository<Vessel> vesselRepository, IMapper mapper)
    {
        VesselRepository = vesselRepository;
        Mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetVessels([FromQuery] int page = 1,[FromQuery] int qtde = 10)
    {
        return Ok(VesselRepository.GetAll(page, qtde));
    }

    [HttpGet("id")]
    public IActionResult GetVesselsById(int id)
    {
        return Ok(VesselRepository.GetById(id));
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateVesselDto dto)
    {
        var vessel = Mapper.Map<Vessel>(dto);
        var vesselInserted = VesselRepository.Insert(vessel);
        return CreatedAtAction(nameof(GetVesselsById), new { Id = vesselInserted.Id }, dto);
    }

    [HttpPut]
    public IActionResult Put([FromBody] UpdateVesselDto dto)
    {
        var vessel = Mapper.Map<Vessel>(dto);
        var vesselInserted = VesselRepository.Update(vessel);
        return Ok(vesselInserted);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        VesselRepository.DeleteById(id);
        return NoContent();
    }
}
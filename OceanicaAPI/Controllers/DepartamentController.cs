using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OceanicaAPI.Models;
using OceanicaAPI.Repository.Abstract;

namespace OceanicaAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class DepartamentController : ControllerBase
{
    public IMapper Mapper;
    public IRepository<Departament> DepartamentRepository;

    public DepartamentController(IRepository<Departament> vesselRepository, IMapper mapper)
    {
        DepartamentRepository = vesselRepository;
        Mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetDepartaments([FromQuery] int page = 1, [FromQuery] int qtde = 10)
    {
        return Ok(DepartamentRepository.GetAll(page, qtde));
    }

    [HttpGet("id")]
    public IActionResult GetDepartamentsById(int id)
    {
        return Ok(DepartamentRepository.GetById(id));
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateDepartamentDto dto)
    {
        var vessel = Mapper.Map<Departament>(dto);
        var vesselInserted = DepartamentRepository.Insert(vessel);
        return CreatedAtAction(nameof(GetDepartamentsById), new { Id = vesselInserted.Id }, dto);
    }

    [HttpPut]
    public IActionResult Put([FromBody] UpdateDepartamentDto dto)
    {
        var vessel = Mapper.Map<Departament>(dto);
        var vesselInserted = DepartamentRepository.Update(vessel);
        return Ok(vesselInserted);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        DepartamentRepository.DeleteById(id);
        return NoContent();
    }
}

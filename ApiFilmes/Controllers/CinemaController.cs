using ApiFilmes.Data.Dto;
using ApiFilmes.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiFilmes.Controllers;
using ApiFilmes.Data;


[ApiController]
[Route("[controller]")]
public class CinemaController: ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;
    
    public CinemaController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    [HttpPost]
    public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
    {
        Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
        _context.Cinemas.Add(cinema);
        _context.SaveChanges();
        return Ok(cinema); // alter to return the object.
    }
    
    [HttpGet]
    public IEnumerable<ReadCinemaDto> RecuperaCinema ([FromQuery]int skip = 0, [FromQuery]int take = 20)
    {
        return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.Skip(skip).Take(take));
    }
    
    // Implement GetById method.
    
    // Implement Update Method.
    
    // Implement Delete method.



}
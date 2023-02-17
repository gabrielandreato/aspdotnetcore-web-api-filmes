using System.Collections.Specialized;
using ApiFilmes.Data.Dto;
using ApiFilmes.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
    [HttpGet("{id}")]
    public IActionResult RecuperaCinemaPorID(int id)
    {
        var filme = _context.Cinemas.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeDto = _mapper.Map<Cinema>(filme);
        return Ok(filmeDto);

    }

    // Implement Update Method.
    [HttpPut("{id}")]
    public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
    {
        var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null) return NotFound();
        _mapper.Map(cinemaDto, cinema);
        _context.SaveChanges();
        return NoContent();
    }

    
    // Implement Delete method.
    [HttpDelete("{id}")]
    public IActionResult DeletaCinema(int id)
    {
        var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null) return NotFound();
        _context.Remove(cinema);
        _context.SaveChanges();
        return NoContent();
    }
}
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("movies")]
[ApiController]
public class MoviesController : Controller
{
  private readonly IMovieService movieservice;

  public MoviesController(IMovieService movieservice) => this.movieservice = movieservice;

  [HttpGet("GetMovies")]
  public IActionResult GetMovies() => Ok(movieservice.GetFilms());

  [HttpGet("GetMovie/{id}")]
  public IActionResult GetMovie(int id)
  {
    var Film = movieservice.GetFilm(id);
    if(Film == null)
      return NoContent();
    return Ok(Film);
  }
}
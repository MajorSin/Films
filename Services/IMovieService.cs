public interface IMovieService
{
  FilmMetAfbeeldingen[] GetFilms();

  FilmMetAfbeeldingen? GetFilm(int id);
}

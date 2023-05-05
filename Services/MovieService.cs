public class MovieService : IMovieService
{
  public DatabaseContext db;

  public MovieService() => db = new DatabaseContext();

  public FilmMetAfbeeldingen[] GetFilms()
  {
    var films = db.FilmsTable.ToList();
    var filmsWithImages = (from film in films
                          join poster in db.PosterTable on film.Id equals poster.FilmId into postersGroup
                          join banner in db.BannerTable on film.Id equals banner.FilmId into bannersGroup
                          select new FilmMetAfbeeldingen {
                            Id = film.Id,
                            Titel = film.Titel,
                            Beschrijving = film.Beschrijving,
                            ReleaseDatum = film.ReleaseDatum,
                            Looptijd = film.Looptijd,
                            Posters = postersGroup.Select(p => new Poster { Id = p.Id, FilmId = p.FilmId, ImageLink = p.ImageLink }).ToList(),
                            Banners = bannersGroup.Select(b => new Banner { Id = b.Id, FilmId = b.FilmId, ImageLink = b.ImageLink }).ToList()
                          }).ToArray();

    return filmsWithImages;
  }

  public FilmMetAfbeeldingen? GetFilm(int id)
  {
    var films = this.GetFilms();
    var Film = (from film in films 
                where film.Id == id 
                select film).FirstOrDefault();

    if(Film == null)
      return null;
    return Film;
  }
}
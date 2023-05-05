public interface IImage 
{
  int Id { get; set; }
  Films Film { get; set; }
  int FilmId { get; set; }
  string ImageLink { get; set; }
}
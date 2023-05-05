using System.ComponentModel.DataAnnotations;

public class Banner : IImage
{
  [Key]
  public int Id { get; set; }
  public Films Film { get; set; } = null!;
  public int FilmId { get; set; }
  public string ImageLink { get; set; } = null!;

  public Banner() {  }
}
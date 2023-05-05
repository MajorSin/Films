using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Films
{
  [Key]
  public int Id { get; set; }
  [DataType("varchar(30)")]
  public string Titel { get; set; } = null!;
  public string Beschrijving { get; set; } = null!;
  public DateTime ReleaseDatum { get; set; }
  public int Looptijd { get; set; }
  public List<Poster> Posters { get; set; } = null!;
  public List<Banner> Banners { get; set; } = null!;

  public Films() {  }
}
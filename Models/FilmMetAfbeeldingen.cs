public class FilmMetAfbeeldingen
{
    public int Id { get; set; }
    public string Titel { get; set; } = null!;
    public string Beschrijving { get; set; } = null!;
    public DateTime ReleaseDatum { get; set; }
    public int Looptijd { get; set; }
    public List<Poster> Posters { get; set; } = null!;
    public List<Banner> Banners { get; set; } = null!;
}

using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext {
  public DbSet<Films> FilmsTable { get; set; } = null!;
  public DbSet<Banner> BannerTable { get; set; } = null!;
  public DbSet<Poster> PosterTable { get; set; } = null!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseNpgsql("User ID = postgres; Password = 1; Host = localhost; port = 5432; Database = MoviesAPI; Pooling = true");
  }
}
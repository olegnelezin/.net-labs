namespace KinoPoisk.Kinopoisk.DataAccess.Entities;

public class Genre
{
    public int Id { get; set; }
    
    public string GenreValue { get; set; }
    
    public List<Movie> Movies { get; set; }
}
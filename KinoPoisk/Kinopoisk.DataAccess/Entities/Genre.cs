using System.ComponentModel.DataAnnotations.Schema;

namespace KinoPoisk.Kinopoisk.DataAccess.Entities;

[Table("genres")]
public class Genre
{
    public int Id { get; set; }
    
    public string GenreValue { get; set; }
    
    public List<Movie> Movies { get; set; }
}
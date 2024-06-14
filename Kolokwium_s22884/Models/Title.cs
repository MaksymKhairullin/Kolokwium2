using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_s22884.Models;

[Table("Titles")]
public class Title
{
    [Key]
    [Column("PK")]
    public int PkTitle { get; set; }
    
    [MaxLength(100)]
    [Column("nam")]
    public string Name { get; set; }

    public IEnumerable<CharacterTitle> CharacterTitles { get; set; }

}
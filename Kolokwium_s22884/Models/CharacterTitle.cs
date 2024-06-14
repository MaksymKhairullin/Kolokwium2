using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_s22884.Models;


[Table("Characters_Titles")]
[PrimaryKey(nameof(IdCharacter), nameof(IdTitle))]
public class CharacterTitle
{
    [ForeignKey("Character")]
    [Column("FK_charact")]
    public int IdCharacter { get; set; }
    
    [ForeignKey("Title")]
    [Column("FK_title")]
    public int IdTitle { get; set; }
    
    [Column("aquire_at")] 
    public DateTime AquireAt { get; set; }
    
    public Character Character { get; set; }

    public Title Title { get; set; }
}
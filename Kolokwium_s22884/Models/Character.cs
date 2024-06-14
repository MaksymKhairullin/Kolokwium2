using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_s22884.Models;

[Table("Characters")]
public class Character
{
    [Key]
    [Column("PK")]
    public int PkCharacter { get; set; }
    [MaxLength(50)]
    [Column("first_name")]
    public string FirstName { get; set; }
    [MaxLength(50)]
    [Column("last_name")]
    public string SecondName { get; set; }
    [Column("current_weig")]
    public int CurrentWeig { get; set; }
    [Column("max_weight")]
    public int MaxWeight { get; set; }
    [Column("money")]
    public int Money { get; set; }
    
    public IEnumerable<BackPackSlot> BackpackSlots { get; set; }
    
    public IEnumerable<CharacterTitle> CharacterTitles { get; set; }
}
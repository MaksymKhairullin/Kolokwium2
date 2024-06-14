using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_s22884.Models;

[Table("BackPack_Slots")]
public class BackPackSlot
{
    [Key]
    [Column("PK")]
    public int PkBackpack { get; set; }

    [Column("Fk_item")]
    [ForeignKey("Item")] 
    public int IdItem { get; set; }
    
    [Column("Fk_character")]
    [ForeignKey("Character")] 
    public int IdCharacter { get; set; }
    
    public Item Item { get; set; }
    public Character Character { get; set; } 
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Kolokwium_s22884.Models;

[Table("Items")]
public class Item
{
    [Key]
    [Column("PK")]
    public int PkItem { get; set; }
    
    [MaxLength(50)]
    [Column("name")]
    public string Name { get; set; }

    [Column("weig")]
    public int Weight { get; set; }
    
    public IEnumerable<BackPackSlot> BackpackSlots { get; set; }
 
}
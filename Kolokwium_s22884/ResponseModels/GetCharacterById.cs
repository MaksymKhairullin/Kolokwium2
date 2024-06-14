namespace Kolokwium_s22884.ResponseModels;

public class GetCharacterById
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int currentWeight { get; set; }
    public int maxWeight { get; set; }
    public int money { get; set; }
    public  IEnumerable<GetBackPackSlot> BackPackSlots { get; set; }
    public IEnumerable<GetTitle> Titles { get; set; }
    
}

public class GetBackPackSlot
{
    public int slotId { get; set; }
    public string itemName { get; set; }
    public int itemWeight { get; set; }
}

public class GetTitle
{
    public string title { get; set; }
    public DateTime aquireAt { get; set; }
}

public class BackPackSlot
{
    
}

using Kolokwium_s22884.Context;
using Kolokwium_s22884.Exceptions;
using Kolokwium_s22884.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_s22884.Services;


public interface IService
{
    Task<GetCharacterById> GetCharacterByIdAsync(int id);
    Task<(bool Success, string Message)> AddItemsToBackpackAsync(int characterId, List<int> itemIds);
    
}

public class Service(DatabaseContext _databaseContext) : IService
{
    public async Task<GetCharacterById> GetCharacterByIdAsync(int id)
    {
        var result = await _databaseContext.Characters
            .Where(c => c.PkCharacter == id)
            .Select(c => new GetCharacterById
            {
                firstName = c.FirstName,
                lastName = c.SecondName,
                currentWeight = c.CurrentWeig,
                maxWeight = c.MaxWeight,
                money = c.Money,
                BackPackSlots = c.BackpackSlots.Select(bs => new GetBackPackSlot
                {
                    slotId = bs.IdItem,
                    itemName = bs.Item.Name,
                    itemWeight = bs.Item.Weight
                }).ToList(),
                Titles = c.CharacterTitles.Select(ct => new GetTitle
                {
                    title = ct.Title.Name,
                    aquireAt = ct.AquireAt
                }).ToList()
            })
            .FirstOrDefaultAsync();

        if (result is null)
        {
            throw new NotFoundException("Your id doesnt exit in database");
        }
        return result;
    }

    public  async Task<(bool Success, string Message)> AddItemsToBackpackAsync(int characterId, List<int> itemIds)
    {
        var character = await _databaseContext.Characters
            .Include(c => c.BackpackSlots)
            .ThenInclude(bs => bs.Item)
            .FirstOrDefaultAsync(c => c.PkCharacter == characterId);
        
        if (character == null)
        {
            return (false, "Character not found");
        }
        
        var items = await _databaseContext.Items
            .Where(i => itemIds.Contains(i.PkItem))
            .ToListAsync();

        if (items.Count != itemIds.Count)
        {
            return (false, "One or more items not found in the database");
        }
        
        var totalWeight = items.Sum(i => i.Weight);
        if (character.CurrentWeig + totalWeight > character.MaxWeight)
        {
            return (false, "Character does not have enough capacity for these items");
        }
        
        
        // foreach (var item in items)
        // {
        //     character.BackpackSlots.Add(new BackPackSlot()
        //     {
        //         IdCharacter = characterId,
        //         FK_Item = item.PkItem
        //     });
        // }
        //nie wystarczylo mi czasu
        character.CurrentWeig += totalWeight;
        
        await _databaseContext.SaveChangesAsync();

        return (true, "Items added to backpack");
    }
}
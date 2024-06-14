using Kolokwium_s22884.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_s22884.Context;

public class DatabaseContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<BackPackSlot> BackPackSlots { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }

    protected DatabaseContext() 
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}
using System.Collections.Generic;

public interface IHero
{
    string Name { get; }

    void AddItem(IItem item);

    void AddRecipe(IRecipe recipe);

    long Intelligence { get; }

    long HitPoints { get; }

    long Damage { get; }

    IInventory Inventory { get; }

    long Strength { get; }

    long Agility { get; }

    ICollection<IItem> Items { get; }

    long PrimaryStats { get; }
    
    long SecondaryStats { get; }
    
}


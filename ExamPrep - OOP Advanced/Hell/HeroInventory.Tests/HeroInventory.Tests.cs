

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class HeroInventoryTests
{
    private HeroInventory sut;

    [SetUp]
    public void TestInit()
    {
        this.sut = new HeroInventory();
    }

    [Test]
    public void AddCommonItem()
    {
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute)) != null);

        var collection = (Dictionary<string, IItem>)field.GetValue(this.sut);

        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void AddRecipeItem()
    {
        RecipeItem item = new RecipeItem("item", 10, 10, 10, 10, 10, new List<string>());

        this.sut.AddRecipeItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetField("recipeItems", BindingFlags.Instance | BindingFlags.NonPublic);

        var collection = (Dictionary<string, IRecipe>)field.GetValue(this.sut); //?

        Assert.AreEqual(1, collection.Count);
    }


    [Test]
    public void StrenghtBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalAgilityBonus);
    }

    [Test]
    public void TotalIntelligenceBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalIntelligenceBonus);
    }

    [Test]
    public void TotalHitPointsBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalHitPointsBonus);
    }

    [Test]
    public void TotalDamageBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(10, this.sut.TotalDamageBonus);
    }

}
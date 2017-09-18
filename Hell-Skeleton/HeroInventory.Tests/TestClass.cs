using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


[TestFixture]
public class TestClass
{
    private HeroInventory sut;

    [SetUp]
    public void StartTest()
    {
        sut = new HeroInventory();
    }

    [Test]
    public void TotalStrengthBonus()
    {
        var item = new CommonItem("ivan", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(1, sut.TotalStrengthBonus);
    }

    [Test]
    public void TotalAgilityBonus()
    {
        var item = new CommonItem("ivan", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(2, sut.TotalAgilityBonus);
    }

    [Test]
    public void TotalIntelligenceBonus()
    {
        var item = new CommonItem("ivan", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(3, sut.TotalIntelligenceBonus);
    }

    [Test]
    public void TotalHitPointsBonus()
    {
        var item = new CommonItem("ivan", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(4, sut.TotalHitPointsBonus);
    }

    [Test]
    public void TotalDamageBonus()
    {
        var item = new CommonItem("ivan", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(5, sut.TotalDamageBonus);
    }

    [Test]
    public void CheckRecipeForItem()
    {
        var item = new CommonItem("Knife", 1, 2, 3, 4, 5);
        var item1 = new CommonItem("Axe", 1, 2, 3, 4, 5);
        var recipeItem = new RecipeItem("Spear", 11, 22, 33, 44, 55, new List<string> { "Knife", "Axe" });

        var type = typeof(HeroInventory);
        var field = type.GetField("CheckRecipes");

        var fieldvalue = field.GetValue(sut);

        Assert.
    }
}

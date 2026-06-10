using TShirtShop.Enums;

namespace TShirtShop.Models;

public class MiddleEastSmallTShirt : TShirt
{
    public MiddleEastSmallTShirt()
    {
        Name = "Middle East Small T-Shirt";
        Size = TShirtSize.Small;
        Region = TShirtRegion.MiddleEast;
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Middle East region");
    }
}

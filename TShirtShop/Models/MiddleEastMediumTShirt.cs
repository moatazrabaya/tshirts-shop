using TShirtShop.Enums;

namespace TShirtShop.Models;

public class MiddleEastMediumTShirt : TShirt
{
    public MiddleEastMediumTShirt()
    {
        Name = "Middle East Medium T-Shirt";
        Size = TShirtSize.Medium;
        Region = TShirtRegion.MiddleEast;
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for Middle East region");
    }
}

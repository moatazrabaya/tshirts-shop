using TShirtShop.Enums;

namespace TShirtShop.Models;

public class MiddleEastLargeTShirt : TShirt
{
    public MiddleEastLargeTShirt()
    {
        Name = "Middle East Large T-Shirt";
        Size = TShirtSize.Large;
        Region = TShirtRegion.MiddleEast;
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for Middle East region");
    }
}

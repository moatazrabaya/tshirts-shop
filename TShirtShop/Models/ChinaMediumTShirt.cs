using TShirtShop.Enums;

namespace TShirtShop.Models;

public class ChinaMediumTShirt : TShirt
{
    public ChinaMediumTShirt()
    {
        Name = "China Medium T-Shirt";
        Size = TShirtSize.Medium;
        Region = TShirtRegion.China;
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for China region");
    }
}

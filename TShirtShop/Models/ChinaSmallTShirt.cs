using TShirtShop.Enums;

namespace TShirtShop.Models;

public class ChinaSmallTShirt : TShirt
{
    public ChinaSmallTShirt()
    {
        Name = "China Small T-Shirt";
        Size = TShirtSize.Small;
        Region = TShirtRegion.China;
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for China region");
    }
}

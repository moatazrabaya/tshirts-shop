using TShirtShop.Enums;

namespace TShirtShop.Models;

public class AsiaSmallTShirt : TShirt
{
    public AsiaSmallTShirt()
    {
        Name = "Asia Small T-Shirt";
        Size = TShirtSize.Small;
        Region = TShirtRegion.Asia;
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Asia region");
    }
}

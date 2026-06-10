using TShirtShop.Enums;

namespace TShirtShop.Models;

public class AsiaLargeTShirt : TShirt
{
    public AsiaLargeTShirt()
    {
        Name = "Asia Large T-Shirt";
        Size = TShirtSize.Large;
        Region = TShirtRegion.Asia;
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for Asia region");
    }
}

using TShirtShop.Enums;

namespace TShirtShop.Models;

public class ChinaLargeTShirt : TShirt
{
    public ChinaLargeTShirt()
    {
        Name = "China Large T-Shirt";
        Size = TShirtSize.Large;
        Region = TShirtRegion.China;
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for China region");
    }
}

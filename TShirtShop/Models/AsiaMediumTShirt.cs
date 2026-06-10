using TShirtShop.Enums;

namespace TShirtShop.Models;

public class AsiaMediumTShirt : TShirt
{
    public AsiaMediumTShirt()
    {
        Name = "Asia Medium T-Shirt";
        Size = TShirtSize.Medium;
        Region = TShirtRegion.Asia;
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for Asia region");
    }
}

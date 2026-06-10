namespace TShirtShop.Models;

public class AsiaSmallTShirt : TShirt
{
    public AsiaSmallTShirt()
    {
        Name = "Asia Small T-Shirt";
        Size = "Small";
        Region = "Asia";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Asia region");
    }
}

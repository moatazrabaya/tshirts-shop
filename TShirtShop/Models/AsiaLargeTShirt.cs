namespace TShirtShop.Models;

public class AsiaLargeTShirt : TShirt
{
    public AsiaLargeTShirt()
    {
        Name = "Asia Large T-Shirt";
        Size = "Large";
        Region = "Asia";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for Asia region");
    }
}

namespace TShirtShop.Models;

public class AsiaLargeTShirt : TShirt
{
    public AsiaLargeTShirt()
    {
        Name = "Asia Large T-Shirt";
        Description = "A large T-shirt designed for the Asia region";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for Asia region");
    }
}

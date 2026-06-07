namespace TShirtShop.Models;

public class AsiaSmallTShirt : TShirt
{
    public AsiaSmallTShirt()
    {
        Name = "Asia Small T-Shirt";
        Description = "A small T-shirt designed for the Asia region";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Asia region");
    }
}

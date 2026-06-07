namespace TShirtShop.Models;

public class AsiaMediumTShirt : TShirt
{
    public AsiaMediumTShirt()
    {
        Name = "Asia Medium T-Shirt";
        Description = "A medium T-shirt designed for the Asia region";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for Asia region");
    }
}

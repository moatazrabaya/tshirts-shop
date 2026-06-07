namespace TShirtShop.Models;

public class ChinaMediumTShirt : TShirt
{
    public ChinaMediumTShirt()
    {
        Name = "China Medium T-Shirt";
        Description = "A medium T-shirt designed for the China market";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for China region");
    }
}

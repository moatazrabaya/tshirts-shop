namespace TShirtShop.Models;

public class MiddleEastMediumTShirt : TShirt
{
    public MiddleEastMediumTShirt()
    {
        Name = "Middle East Medium T-Shirt";
        Description = "A medium T-shirt designed for the Middle East market";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for Middle East region");
    }
}

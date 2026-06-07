namespace TShirtShop.Models;

public class MiddleEastSmallTShirt : TShirt
{
    public MiddleEastSmallTShirt()
    {
        Name = "Middle East Small T-Shirt";
        Description = "A small T-shirt designed for the Middle East region";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Middle East region");
    }
}

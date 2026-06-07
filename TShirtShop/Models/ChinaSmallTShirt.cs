namespace TShirtShop.Models;

public class ChinaSmallTShirt : TShirt
{
    public ChinaSmallTShirt()
    {
        Name = "China Small T-Shirt";
        Description = "A small T-shirt designed for the China region";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for China region");
    }
}

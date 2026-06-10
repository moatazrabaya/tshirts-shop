namespace TShirtShop.Models;

public class ChinaSmallTShirt : TShirt
{
    public ChinaSmallTShirt()
    {
        Name = "China Small T-Shirt";
        Size = "Small";
        Region = "China";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for China region");
    }
}

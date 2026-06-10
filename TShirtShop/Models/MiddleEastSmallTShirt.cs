namespace TShirtShop.Models;

public class MiddleEastSmallTShirt : TShirt
{
    public MiddleEastSmallTShirt()
    {
        Name = "Middle East Small T-Shirt";
        Size = "Small";
        Region = "MiddleEast";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Small size formatted for Middle East region");
    }
}

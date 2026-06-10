namespace TShirtShop.Models;

public class ChinaMediumTShirt : TShirt
{
    public ChinaMediumTShirt()
    {
        Name = "China Medium T-Shirt";
        Size = "Medium";
        Region = "China";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for China region");
    }
}

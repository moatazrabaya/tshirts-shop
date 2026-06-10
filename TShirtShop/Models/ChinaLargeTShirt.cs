namespace TShirtShop.Models;

public class ChinaLargeTShirt : TShirt
{
    public ChinaLargeTShirt()
    {
        Name = "China Large T-Shirt";
        Size = "Large";
        Region = "China";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for China region");
    }
}

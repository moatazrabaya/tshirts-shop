namespace TShirtShop.Models;

public class AsiaMediumTShirt : TShirt
{
    public AsiaMediumTShirt()
    {
        Name = "Asia Medium T-Shirt";
        Size = "Medium";
        Region = "Asia";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Medium size formatted for Asia region");
    }
}

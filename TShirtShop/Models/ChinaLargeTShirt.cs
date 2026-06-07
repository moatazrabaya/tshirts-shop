namespace TShirtShop.Models;

public class ChinaLargeTShirt : TShirt
{
    public ChinaLargeTShirt()
    {
        Name = "China Large T-Shirt";
        Description = "A large T-shirt designed for the China region";
    }

    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for China region");
    }
}

namespace TShirtShop.Models;

public class MiddleEastLargeTShirt : TShirt
{
    public MiddleEastLargeTShirt()
    {
        Name = "Middle East Large T-Shirt";
        Description = "A large T-shirt designed for the Middle East region";
    }
    public override void FormSize()
    {
        System.Console.WriteLine("Large size formatted for Middle East region");
    }
}

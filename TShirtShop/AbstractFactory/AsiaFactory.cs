using TShirtShop.Models;

namespace TShirtShop.AbstractFactory;

public class AsiaFactory : TShirtFactory
{
    public override TShirt CreateSmall() => new AsiaSmallTShirt();
    public override TShirt CreateMedium() => new AsiaMediumTShirt();
    public override TShirt CreateLarge() => new AsiaLargeTShirt();
}

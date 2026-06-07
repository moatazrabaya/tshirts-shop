using TShirtShop.Models;

namespace TShirtShop.AbstractFactory;

public class ChinaFactory : TShirtFactory
{
    public override TShirt CreateSmall() => new ChinaSmallTShirt();
    public override TShirt CreateMedium() => new ChinaMediumTShirt();
    public override TShirt CreateLarge() => new ChinaLargeTShirt();
}

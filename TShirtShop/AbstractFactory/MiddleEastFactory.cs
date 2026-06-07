using TShirtShop.Models;

namespace TShirtShop.AbstractFactory;

public class MiddleEastFactory : TShirtFactory
{
    public override TShirt CreateSmall() => new MiddleEastSmallTShirt();
    public override TShirt CreateMedium() => new MiddleEastMediumTShirt();
    public override TShirt CreateLarge() => new MiddleEastLargeTShirt();
}

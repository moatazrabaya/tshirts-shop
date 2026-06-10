using TShirtShop.Models;

namespace TShirtShop.Decorator;

public class RedColorDecorator : TShirtDecorator
{
    public RedColorDecorator(TShirt tshirt) : base(tshirt)
    {

    }
    public override string Description => $"{_tshirt.Description} + Red Color";
}

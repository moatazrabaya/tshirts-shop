using TShirtShop.Models;

namespace TShirtShop.Decorator;

public class BlueColorDecorator : TShirtDecorator
{
    public BlueColorDecorator(TShirt tshirt) : base(tshirt)
    {

    }
    public override string Description => $"{_tshirt.Description} + Blue Color";
}
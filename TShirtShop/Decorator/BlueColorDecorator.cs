using TShirtShop.Models;

namespace TShirtShop.Decorator;

public class BlueColorDecorator : TShirtDecorator
{
    public BlueColorDecorator(TShirt tshirt) : base(tshirt)
    {

    }
    public override string FullDescription => $"{_tshirt.FullDescription} + Blue Color";
}
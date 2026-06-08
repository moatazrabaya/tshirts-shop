using TShirtShop.Models;

namespace TShirtShop.Decorator;

public class TextDecorator : TShirtDecorator
{
    public TextDecorator(TShirt tshirt) : base(tshirt)
    {

    }
    public override string FullDescription => $"{_tshirt.FullDescription} + \"Nice Day!\"";
}

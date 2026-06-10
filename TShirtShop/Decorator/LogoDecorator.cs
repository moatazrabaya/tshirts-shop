using TShirtShop.Models;

namespace TShirtShop.Decorator;

public class LogoDecorator : TShirtDecorator
{
    public LogoDecorator(TShirt tshirt) : base(tshirt)
    {

    }
    public override string Description => $"{_tshirt.Description} + Bird Logo";
}

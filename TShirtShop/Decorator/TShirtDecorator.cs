using TShirtShop.Models;

namespace TShirtShop.Decorator;

public abstract class TShirtDecorator : TShirt
{
    protected TShirt _tshirt;

    public TShirtDecorator(TShirt tshirt)
    {
        _tshirt = tshirt;
    }

    public abstract override string Description {get;}

    public override void FormSize() => _tshirt.FormSize();
}

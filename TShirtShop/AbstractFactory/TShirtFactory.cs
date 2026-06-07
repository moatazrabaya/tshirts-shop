using TShirtShop.Models;

namespace TShirtShop.AbstractFactory;

public abstract class TShirtFactory
{
    public abstract TShirt CreateSmall();
    public abstract TShirt CreateMedium();
    public abstract TShirt CreateLarge();
}

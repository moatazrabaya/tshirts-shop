using TShirtShop.AbstractFactory;
using TShirtShop.Decorator;
using TShirtShop.Models;
using TShirtShop.Observer;
using TShirtShop.Singleton;

namespace TShirtShop;

class Program
{
    static void Main(String[] args)
    {
        SalesTracker tracker = SalesTracker.Instance;

        ShopOwner owner = new("Moataz");

        tracker.RegisterObserver(owner);

        TShirtFactory factory = new ChinaFactory();

        TShirt tshirt = factory.CreateMedium();

        tshirt = new LogoDecorator(tshirt);

        tshirt = new BlueColorDecorator(tshirt);

        Order order = Order.Instance;

        order.PlaceOrder(tshirt);

        order.ShowOrder();

        order.CompleteOrder();

    }
}

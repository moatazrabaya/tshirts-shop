using TShirtShop.Models;

namespace TShirtShop.Singleton;

public class Order
{
    private TShirt? _tshirt;
    private static Order? _instance;

    public static Order Instance => _instance ??= new Order();
    
    private Order() { }

    public void PlaceOrder(TShirt tshirt)
    {
        if(_tshirt != null)
        {
            System.Console.WriteLine("You already have an active order. Complete it first.");
            return;
        }
        _tshirt = tshirt;
        System.Console.WriteLine($"Order placed: {_tshirt.FullDescription}");
    }

    public void CompleteOrder()
    {
        if(_tshirt is null)
        {
            System.Console.WriteLine("No active order to complete.");
            return;
        }
        System.Console.WriteLine($"Order completed: {_tshirt.FullDescription}");
        _tshirt = null;
    }

    public void ShowOrder()
    {
        if(_tshirt is null)
            System.Console.WriteLine("No active order.");
        else
            System.Console.WriteLine($"Current order: {_tshirt.FullDescription}");
    }
}

namespace TShirtShop.Observer;

public class ShopOwner : IObserver
{
    private string _name;

    public int SmallSold {get; private set;}
    public int MediumSold {get; private set;}
    public int LargeSold {get; private set;}
    public int TotalSold => SmallSold + MediumSold + LargeSold;

    public ShopOwner(string name)
    {
        _name = name;
    }

    public void Update(int smallSold, int mediumSold, int largeSold)
    {
        SmallSold = smallSold;
        MediumSold = mediumSold;
        LargeSold = largeSold;
    }

    public void PrintReport()
    {
        Console.WriteLine($"\n[{_name} Notification]");
        Console.WriteLine($"  Small  sold: {SmallSold}");
        Console.WriteLine($"  Medium sold: {MediumSold}");
        Console.WriteLine($"  Large  sold: {LargeSold}");
        Console.WriteLine($"-------------------------------");
        Console.WriteLine($"Total  sold: {TotalSold}");
        System.Console.WriteLine();
    }
}

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
}

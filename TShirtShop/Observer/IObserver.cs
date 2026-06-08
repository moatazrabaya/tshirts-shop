namespace TShirtShop.Observer;

public interface IObserver
{
    void Update(int smallSold, int mediumSold, int largeSold);
}

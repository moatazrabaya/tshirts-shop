using TShirtShop.Enums;
using TShirtShop.Models;

namespace TShirtShop.Observer;

public class SalesTracker : ISubject
{
    private int _smallSold = 0;
    private int _mediumSold = 0;
    private int _largeSold = 0;

    private static SalesTracker? _instance;

    private List<IObserver> _observers = new();

    public static SalesTracker Instance => _instance ??=new SalesTracker();

    private SalesTracker() {}

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(var observer in _observers)
            observer.Update(_smallSold, _mediumSold, _largeSold);
    }

    public void AddSale(TShirtSize size)
    {
        switch (size)
        {
            case TShirtSize.Small: _smallSold++; break;
            case TShirtSize.Medium: _mediumSold++; break;
            case TShirtSize.Large: _largeSold++; break;
        }
        NotifyObservers();
    }
}

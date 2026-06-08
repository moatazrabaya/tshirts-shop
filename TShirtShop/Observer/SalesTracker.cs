namespace TShirtShop.Observer;

public class SalesTracker : ISubject
{
    private int _smallSold = 0;
    private int _mediumSold = 0;
    private int _largeSold = 0;

    private List<IObserver> _observers = new();

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

    public void AddSale(string size)
    {
        switch (size.ToLower())
        {
            case "small": _smallSold++; break;
            case "medium": _mediumSold++; break;
            case "large": _largeSold++; break;
        }
        NotifyObservers();
    }
}

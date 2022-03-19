namespace Observer.Entities;

public class WeatherData : Subject
{
    private List<Observer> _observers;
    private WeatherCharacteristics _data = new();

    public WeatherCharacteristics Data
    {
        get => _data;
        set
        {
            _data = value;
            MeasurmentsChanged();
        }
    }

    public WeatherData()
    {
        _observers = new List<Observer>();
    }

    public void RegisterObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void removeObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        Console.WriteLine("Notifying Observers...");
        _observers.ForEach(x => x.Update(Data));
    }

    public void MeasurmentsChanged()
    {
        NotifyObservers();  
    }
    
    
}
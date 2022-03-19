namespace Observer.Entities;

public class CurrentConditionDisplay: DisplayElement,Observer
{
    private WeatherCharacteristics _data = new WeatherCharacteristics();
    private Subject _weatherData;

    public CurrentConditionDisplay(Subject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
        
    }
    
    public void Display()
    {
        Console.WriteLine("Temperature is " + _data.Temperature);
    }

    public void Update(WeatherCharacteristics data)
    {
        _data = data;
        Display();
    }
}
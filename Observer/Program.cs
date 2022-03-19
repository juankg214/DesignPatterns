// See https://aka.ms/new-console-template for more information

using Observer.Entities;

WeatherData subject = new ();
var dis = new CurrentConditionDisplay(subject);
subject.Data = new WeatherCharacteristics()
{
    Humidity = 4,
    Pressure = 5,
    Temperature = 7
};


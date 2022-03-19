namespace Observer.Entities;

public interface Subject
{
    public void RegisterObserver(Observer observer);
    public void removeObserver(Observer observer);
    public void NotifyObservers();
}
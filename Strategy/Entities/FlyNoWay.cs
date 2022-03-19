namespace DuckChapter1.Entities;

public class FlyNoWay : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't Fly!!!!");
    }
}
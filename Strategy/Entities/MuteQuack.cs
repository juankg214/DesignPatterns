namespace DuckChapter1.Entities;

public class MuteQuack : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Silence");
    }
}
namespace DuckChapter1.Entities;

public class MallardDuck : Duck 
{
    public override void display()
    {
        Console.WriteLine("I am a Mallard Duck");
    }

    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new QuackMouth();
    }
}
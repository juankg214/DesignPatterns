namespace DuckChapter1.Entities;

public abstract class Duck
{
    protected FlyBehavior FlyBehavior { get; set; }
    protected QuackBehavior QuackBehavior { get; set; }

    public abstract void display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void SetFlyBehaviour(FlyBehavior flyBehavior)
    {
        this.FlyBehavior = flyBehavior;
    }

   
}
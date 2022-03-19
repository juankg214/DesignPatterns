using System.Security.AccessControl;
using System.Threading.Channels;

namespace DuckChapter1.Entities;

public class FlyWithWings : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings");
    }
}
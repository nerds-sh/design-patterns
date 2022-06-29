using System;
namespace wow;

public class Background
{
    public bool HasAGoodBackground(Person p)
    {
        Console.WriteLine("Check background for " + p.Name);
        return true;
    }
}
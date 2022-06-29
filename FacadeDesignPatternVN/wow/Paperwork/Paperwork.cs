using System;
namespace wow;

public class Paperwork
{
    public bool HasAllThePaperwork(Person p)
    {
        Console.WriteLine("Check paperwork for " + p.Name);
        return true;
    }
}
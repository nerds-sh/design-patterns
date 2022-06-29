using System;
namespace wow;
public class Bank
{
    public bool HasSufficientSavings(Person p)
    {
        Console.WriteLine("Check bank for " + p.Name);
        return true;
    }
}
using System;
namespace wow;

public class Adoption
{
    Bank bank = new Bank();
    Paperwork paperwork = new Paperwork();
    Background background = new Background();

    public bool IsEligible(Person pers, string child)
    {
        Console.WriteLine("{0} applies for {1:C}\n", pers.Name, child);

        bool eligible = true;

        if (!bank.HasSufficientSavings(pers))
        {
            eligible = false;
        }
        else if (!paperwork.HasAllThePaperwork(pers))
        {
            eligible = false;
        }
        else if (!background.HasAGoodBackground(pers))
        {
            eligible = false;
        }
        return eligible;
    }
}
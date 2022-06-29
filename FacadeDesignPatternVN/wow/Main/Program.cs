using System;
namespace wow;

public class Program
{
    public static void Main(string[] args)
    {
        Adoption adoption = new Adoption();

        Person person = new Person("Amalia Capatina");
        bool eligible = adoption.IsEligible(person, "Aron");

        Console.WriteLine("\n" + person.Name + " has been " + (eligible ? "Approved" : "Rejected"));

        Console.ReadKey();

    }
}

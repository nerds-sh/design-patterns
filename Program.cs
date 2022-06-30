namespace COMPOSITE
{
public class Client
{
    public static void Main (String[] args)
    {
        Developer dev1 = new Developer(1, "Radu", "Senior Developer");
        Developer dev2 = new Developer(10, "Mihai", "Developer");
        Company devDirectory = new Company();
        devDirectory.addEmployee(dev1);
        devDirectory.addEmployee(dev2);

        Manager mag1 = new Manager(3, "Ana", "General Manager");
        Manager mag2 = new Manager(7, "Ana", "Manager");
        Company magDirectory = new Company();
        magDirectory.addEmployee(mag1);
        magDirectory.addEmployee(mag2);

        HR hr1 = new HR(20, "Adrian", "HR");
        HR hr2 = new HR(18, "Antonia", "HR");
        Company hrDirectory = new Company();
        hrDirectory.addEmployee(hr1);
        hrDirectory.addEmployee(hr2);

        Company Directory = new Company();
        Directory.addEmployee(devDirectory);
        Directory.addEmployee(magDirectory);
        Directory.addEmployee(hrDirectory);
        Directory.showEmployeeDetails();
    }
}
}
using Patterns.Bars;

Patterns.Flyweight.Run();

BarInterface proxyBar = new BarProxy();
Console.WriteLine("\n ----------------Proxy-----------------");
Console.WriteLine(proxyBar.askForMenu());
proxyBar.createOrder("Bere",2);
proxyBar.payUp();


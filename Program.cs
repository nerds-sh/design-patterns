using Patterns.Bars;

Patterns.Flyweight.Run();

BarInterface proxyBar = new BarProxy();
Console.WriteLine("\n ----------------Proxy-----------------"); 
Console.WriteLine(proxyBar.askForMenu());
proxyBar.createOrder("Bere",2);
proxyBar.payUp();


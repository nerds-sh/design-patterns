namespace Patterns.Bars;
public class Bar : BarInterface
{
    string menu = "Beer";
    int price;

    Order currentOrder;
    public void restockDrinks(){}
    public Order bringOrder(){return currentOrder;}
    public string getMenu(){return menu;}

    public string askForMenu(){ return menu;}
    public void payUp(){Console.WriteLine("Woosh, all money gone");}
    public Order createOrder(string name, int amount)
    {
        currentOrder.drinkName = name;
        currentOrder.numberOfDrinks = amount;
        currentOrder.createPrice();
        return currentOrder;
    }
}
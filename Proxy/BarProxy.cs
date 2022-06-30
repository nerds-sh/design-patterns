namespace Patterns.Bars;
public class BarProxy : BarInterface
{
    public string askForMenu()
    {
        Bar realBar = new Bar();
        return realBar.askForMenu();
    }

    public Order createOrder(string name, int amount)
    {
        if(checkAge()){
        Bar realBar = new Bar();
        return realBar.createOrder(name,amount);
        }
        else return null;
    }
    public void payUp(){
        Bar realBar = new Bar();
        realBar.payUp();
    }
    public bool checkAge(){return true;}
}
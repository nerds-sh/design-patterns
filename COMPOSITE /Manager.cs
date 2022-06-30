public class Manager : Interface
{
    private String name;
    private int ID;
    private String position;

    public Manager(int ID, String name, String position)
    {
        this.ID = ID;
        this.name = name;
        this.position = position;
    }

    public void showEmployeeDetails()
    {
        Console.WriteLine(ID + " " + name);
    }
}
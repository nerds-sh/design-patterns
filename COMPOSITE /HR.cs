public class HR : Interface
{
    private String name;
    private int ID;
    private String position;

    public HR(int ID, String name, String position)
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
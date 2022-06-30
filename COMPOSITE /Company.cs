public class Company : Interface
{
    private List<Interface> employeesList = new List<Interface>();

    public void addEmployee(Interface emp)
    {
        employeesList.Add(emp);
    }

    public void showEmployeeDetails()
    {
        foreach(var emp in employeesList)
        {
            emp.showEmployeeDetails();
        }
    }

    public void removeEmployee(Interface emp)
    {
        employeesList.Remove(emp);
    }

}
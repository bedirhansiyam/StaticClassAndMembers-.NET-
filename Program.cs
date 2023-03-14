namespace StaticClassAndMembers;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number of employees : " + Employee.NumberOfEmployees);    // 0

        Employee employee = new Employee("Bedirhan","Siyam","IT");
        Console.WriteLine("Number of employees : " + Employee.NumberOfEmployees);   // 1

        Employee employee1 = new Employee("Cengizhan","Siyam","IT");
        Employee employee2 = new Employee("Sila","Siyam","IT");
        Console.WriteLine("Number of employees : " + Employee.NumberOfEmployees);   //3

        // Static class
        Console.WriteLine(Operations.Sum(25,10));      // 35
        Console.WriteLine(Operations.Subtract(25,10)); // 15
 

    }
}

class Employee
{
    private static int numberOfEmployees;

    public static int NumberOfEmployees { get => numberOfEmployees;}

    private string Name;
    private string Surname;
    private string Department;

    static Employee()
    {
        numberOfEmployees = 0;
    }

    public Employee(string name, string surname, string department)
    {
        Name = name;
        Surname = surname;
        Department = department;
        numberOfEmployees++;
    }
}

// Static class
static class Operations
{
    static public long Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    static public long Subtract(int number1, int number2)
    {
        return number1 - number2;
    }
}

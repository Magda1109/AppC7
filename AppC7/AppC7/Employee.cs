namespace AppC7;

public class Employee
{
    private List<int> grades = new List<int>();
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public int Points
    {
        get
        {
            return this.grades.Sum();
        }
    }

    public Employee(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public void AddGrade(int number)
    {
        this.grades.Add(number);
    }
}


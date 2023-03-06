using static AppC7.EmployeeInMemory;

namespace AppC7;

public abstract class EmployeeBase : IEmployee
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public abstract event GradeAddedDelegate GradeAdded;
    public EmployeeBase(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public abstract void AddGrade(string grade);
    public abstract Statistics GetStatistics();

    public string FirstName { get; private set;  }
    public string LastName { get; private set;  }
    public int Age { get; private set; }
}
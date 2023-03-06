using static AppC7.EmployeeBase;

namespace AppC7;

public interface IEmployee
{
    void AddGrade(string grade);
    Statistics GetStatistics();
    string FirstName { get; }
    string LastName { get; }
    int Age { get; }
    event GradeAddedDelegate GradeAdded;
}
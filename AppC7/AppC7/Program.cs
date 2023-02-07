using AppC7;

Employee emp1 = new Employee("Jan", "Kowalski", 52);
Employee emp2 = new Employee("Katarzyna", "nowak", 25);
Employee emp3 = new Employee("Joanna", "Kurowska", 33);

emp1.AddGrade(1);
emp1.AddGrade(2);
emp1.AddGrade(3);
emp1.AddGrade(4);
emp1.AddGrade(5);

emp2.AddGrade(1);
emp2.AddGrade(1);
emp2.AddGrade(1);
emp2.AddGrade(1);
emp2.AddGrade(1);

emp3.AddGrade(1);
emp3.AddGrade(5);
emp3.AddGrade(5);
emp3.AddGrade(4);
emp3.AddGrade(3);

List<Employee> employees = new List<Employee>() { emp1, emp2, emp3 };

int maxResult = 0;

Employee userWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Points > maxResult)
    {
        maxResult = employee.Points;
        userWithMaxResult = employee;
    }
}

Console.WriteLine($"User with max result: {userWithMaxResult.FirstName} {userWithMaxResult.LastName} with result {maxResult}");
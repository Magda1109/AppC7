using AppC7;

var employee = new Employee("Adam", "Kowalski", 24);
employee.AddGrade(77);
employee.AddGrade(14);
employee.AddGrade(22);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average value is: {statistics.Average:N2}");
Console.WriteLine($"Max value is: {statistics.Max}");
Console.WriteLine($"Min value is: {statistics.Min}");


using AppC7;

var employee = new Employee("Adam", "Kowalski", 24);

while(true)
{
    Console.WriteLine("Provide grade");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
     employee.AddGrade(input);
} 

var statistics = employee.GetStatistics();

Console.WriteLine($"Average value is: {statistics.Average:N2}");
Console.WriteLine($"Max value is: {statistics.Max}");
Console.WriteLine($"Min value is: {statistics.Min}");
Console.WriteLine($"Letter grade: {statistics.AverageLetter}");

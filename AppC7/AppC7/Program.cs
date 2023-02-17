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

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception)
    {
        Console.WriteLine("Exception catched");
    }
    finally
    {
        Console.WriteLine("*************************");
    }

} 

var statistics = employee.GetStatistics();

Console.WriteLine($"Average value is: {statistics.Average:N2}");
Console.WriteLine($"Max value is: {statistics.Max}");
Console.WriteLine($"Min value is: {statistics.Min}");
Console.WriteLine($"Letter grade: {statistics.AverageLetter}");

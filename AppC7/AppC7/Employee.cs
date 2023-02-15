namespace AppC7;

public class Employee
{
    private List<float> grades = new List<float>();
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    
    public float Points
    {
        get
        {
            return grades.Sum();
        }
    }

    public Employee(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public void AddGrade(float grade)
    {
        this.grades.Add(grade);
    }

    public void RemovePoints(int number)
    {
        this.grades.Add(-number);
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;
        
        return statistics;
    }
}


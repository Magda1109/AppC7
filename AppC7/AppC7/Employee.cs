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
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
    }

    public void AddGrade(double grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            
            float floatGrade = (float)grade;
            this.grades.Add(floatGrade);
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
    }

    public void AddGrade(string grade)
    {
        var success = float.TryParse(grade, out float result);
        if (success)
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
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


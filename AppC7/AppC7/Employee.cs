using System.Diagnostics;

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
    public void AddGrade(string grade)
    {
        var success = float.TryParse(grade, out float result);
        if (success)
        {
            if (result >= 0 && result <= 100)
            {
                this.grades.Add(result);
            }
            else
            {
                throw new Exception("Invalid grade.");
            }
        }
        else if (!success)
        {
            switch (grade)
            {
                case "A":
                    this.grades.Add(100);
                    break;
                case "B":
                    this.grades.Add(80);
                    break;
                case "C":
                    this.grades.Add(60);
                    break;
                case "D":
                    this.grades.Add(40);
                    break;
                case "E":
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Incorrect letter"); // jak jest throw, to nie musimy dawać break;
            }
        }
        else
        {
            throw new Exception("Invalid grade");
        }
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

        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'E';
                break;
        }

        return statistics;
    }
}


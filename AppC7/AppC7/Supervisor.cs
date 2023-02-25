namespace AppC7;

public class Supervisor : IEmployee
{
    private List<float> gradesSupervisor = new List<float>();
    public void AddGrade(string grade)
    {
        var success = float.TryParse(grade, out float result);
        if (success)
        {
            if (result >= 0 && result <= 100)
            {
                this.gradesSupervisor.Add(result);
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
                case "6":
                    this.gradesSupervisor.Add(100);
                    break;
                case "5+" or "+5":
                    this.gradesSupervisor.Add(90);
                    break;
                case "5":
                    this.gradesSupervisor.Add(80);
                    break;
                case "4+" or "+4":
                    this.gradesSupervisor.Add(70);
                    break;
                case "4":
                    this.gradesSupervisor.Add(60);
                    break;
                case "3+" or "+3":
                    this.gradesSupervisor.Add(50);
                    break;
                case "3":
                    this.gradesSupervisor.Add(40);
                    break;
                case "2+" or "+2":
                    this.gradesSupervisor.Add(30);
                    break;
                case "2":
                    this.gradesSupervisor.Add(20);
                    break;
                case "1":
                    this.gradesSupervisor.Add(0);
                    break;
                default:
                    throw new Exception("wrong grade"); 
            }
        }
        else
        {
            throw new Exception("Invalid grade");
        }
    }

    public Statistics GetStatistics()
    {
        throw new NotImplementedException();
    }

    public string FirstName => "Magda";
    public string LastName { get; set; }
    public int Age { get; set; }
}
namespace AppC7
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        public override void AddGrade(string grade)
        {
            var success = float.TryParse(grade, out float result);
            if (success)
            {
                if (result >= 0 && result <= 100)
                {
                    this.grades.Add(result);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
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
                    case "a":
                        this.grades.Add(100);
                        GradeAdded(this, new EventArgs());
                        break;
                    case "B":
                    case "b":
                        this.grades.Add(80);
                        GradeAdded(this, new EventArgs());
                        break;
                    case "C":
                    case "c":
                        this.grades.Add(60);
                        GradeAdded(this, new EventArgs());
                        break;
                    case "D":
                    case "d":
                        this.grades.Add(40);
                        GradeAdded(this, new EventArgs());
                        break;
                    case "E":
                    case "e":
                        this.grades.Add(20);
                        GradeAdded(this, new EventArgs());
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}

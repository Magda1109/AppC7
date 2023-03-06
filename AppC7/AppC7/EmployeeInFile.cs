namespace AppC7
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public override void AddGrade(string grade)
        {
            var success = float.TryParse(grade, out float result);
            if (success)
            {
                if (result >= 0 && result <= 100)
                {
                    SaveGradeToFile(result, fileName);
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
                        SaveGradeToFile(100, fileName);
                        break;
                    case "B":
                    case "b":
                        SaveGradeToFile(80, fileName);
                        break;
                    case "C":
                    case "c":
                        SaveGradeToFile(60, fileName);
                        break;
                    case "D":
                    case "d":
                        SaveGradeToFile(40, fileName);
                        break;
                    case "E":
                    case "e":
                        SaveGradeToFile(20, fileName);
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

        private void SaveGradeToFile(float grade, string fileName)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }

            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}")) //sprawdzamy czy plik w ogóle istnieje
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
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

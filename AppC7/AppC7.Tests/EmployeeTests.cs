namespace AppC7.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckAddingPoints()
        {
            //arrange- przygotowujemy test
            var empTest = new Employee("TestFirstName", "TestSurname", 22);
            empTest.AddGrade("33");
            empTest.AddGrade("55");

            //act- wykonujemy test
            var result = empTest.Points;

            //assert- sprawdzamy czy warunek expected zosta³ spe³niony
            Assert.AreEqual(88, result);
        }

        [Test]
        public void CheckStatisticsMethod()
        {
            var empTest = new Employee("TestFirstName", "TestSurname", 22);
            empTest.AddGrade("10");
            empTest.AddGrade("20");
            empTest.AddGrade("30");

            var statTest= empTest.GetStatistics();

            Assert.AreEqual(20, statTest.Average);
            Assert.AreEqual(30, statTest.Max);
            Assert.AreEqual(10, statTest.Min);
        }

        [Test]
        public void CheckLetterGrades()
        {
            var empTest = new Employee("TestFirstName", "TestSurname", 22);

            empTest.AddGrade("A");
            empTest.AddGrade("B");
            empTest.AddGrade("E");

            var letterTest = empTest.GetStatistics();

            Assert.AreEqual(67, Math.Round(letterTest.Average));
            Assert.AreEqual(20, letterTest.Min);
            Assert.AreEqual(100, letterTest.Max);
        }
    }
}
namespace AppC7.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckAddingPoints()
        {
            //arrange- przygotowujemy test
            var empTest = new Employee("TestFirstName", "TestSurname", 22);
            empTest.AddGrade(33);
            empTest.AddGrade(55);

            //act- wykonujemy test
            var result = empTest.Points;

            //assert- sprawdzamy czy warunek expected zosta³ spe³niony
            Assert.AreEqual(88, result);
        }

        [Test]
        public void CheckRemovingPoints()
        {
            var empTest = new Employee("TestFirstName", "TestSurname", 22);
            empTest.AddGrade(33);
            empTest.AddGrade(55);
            empTest.RemovePoints(20);

            var result = empTest.Points;

            Assert.AreEqual(68,result);

        }
    }
}
namespace AppC7.Tests
{
    public class TypeTests
    {
        [Test]

        public void TestReferenceType()
        {
            Employee emp1 = GetEmployee("Anna", "Smith", 57);
            var emp2 = GetEmployee("Anna", "Smith", 57);
            var emp3 = GetEmployee("Adam", "Miller", 33);

            Assert.AreNotEqual(emp1, emp2);
        }

        private Employee GetEmployee(string firstName, string lastName, int age)
        {
            return new Employee(firstName, lastName, age);
        }

        [Test]

        public void TestValueType()
        {
            string number1 = "1";
            string number2 = "1";

            Assert.AreEqual(number1, number2);
        }
    }
}

namespace AppC7;

public abstract class Person
{
    protected Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
}
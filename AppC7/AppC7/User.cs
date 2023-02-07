namespace AppC7;

public class User
{
    private List<int> score = new List<int>();
    public string Login { get; private set; }
    public string Password { get; private set; }
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}

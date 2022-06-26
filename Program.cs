public class SimpleImmutableClass {
    public SimpleImmutableClass(
        string firstName, string lastName, List<string> items
        ) {
        FirstName = firstName;
        LastName = lastName;
        Items = items;
    }

    public string LastName { get; }
    public string FirstName { get; }
    public List<string> Items { get; }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        throw new NotImplementedException();
    }
}

public class Program {

    static void Main() {
        var immutableObject = new SimpleImmutableClass("hehe", "rsrs", new List<string>());
        immutableObject.Items.Add("Fork");
        immutableObject.Items.Add("Spoon");
        Console.WriteLine(immutableObject.FirstName);
        Console.WriteLine(immutableObject.LastName);
        foreach (string item in immutableObject.Items){
            Console.WriteLine(item);
        }

        string[] names = {"hehe", "rsrs"};

        List<User> users = new List<User>();

        User user1 = new User("Hehe", 1996, 26, "hehe@gmail.com");
        User user2 = new User("Rsrs", 1888, 37, "rsrs@hotmail.com");
        users.Add(user1);
        users.Add(user2);

        foreach(User user in users) {
            Console.WriteLine($"Name:{user.Name}\nEmail:{user.Email}\n");
        }
    }
}
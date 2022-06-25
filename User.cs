public class User {

    public User(string name, int yearOfBirth, int age, string email) {
        Name = name;
        YearOfBirth = yearOfBirth;
        Age = age;
        Email = email;
    }
    public string Name { get; }
    public int YearOfBirth { get; }
    public int Age { get; }
    public string Email { get; }
}

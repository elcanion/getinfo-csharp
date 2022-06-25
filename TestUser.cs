using System.Text.RegularExpressions;
class TestUser {
    static void Main() {

        string? name;
        Console.Write("Digite seu nome: ");
        while (String.IsNullOrEmpty(name = Console.ReadLine())) {
            Console.Write("Digite seu nome: ");
        }
        Console.Write("Digite o ano do seu nascimento: ");
        int yearOfBirth;
        while (!int.TryParse(Console.ReadLine(), out yearOfBirth)) {
            Console.Write("Digite um ano de nascimento válido:");
        }
        int age = DateTime.Now.Year - yearOfBirth;
        Console.Write("Digite seu email: ");
        string? email;
        Regex rx = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
        while (String.IsNullOrEmpty(email = Console.ReadLine()) || !rx.IsMatch(email)) {
            Console.Write("Digite um email válido:");
        }

        var user = new User(name, yearOfBirth, age, email);
        Console.WriteLine($"Olá {user.Name}");
        Console.WriteLine($"Você nasceu em {user.YearOfBirth} e você tem {user.Age} anos");
        Console.WriteLine($"Seu email é {user.Email}");
    }
}
using System.Text.RegularExpressions;

Console.Write("Digite seu nome: ");
string? name = Console.ReadLine();
Console.WriteLine($"Olá {name}");
Console.Write("Digite o ano do seu nascimento: ");
int yearOfBirth;
while (!int.TryParse(Console.ReadLine(), out yearOfBirth)) {
    Console.Write("Digite um ano de nascimento válido:");
}
int age = DateTime.Now.Year - yearOfBirth;
Console.WriteLine($"Você nasceu em {yearOfBirth} e você tem {age} anos");
Console.Write("Digite seu email: ");
string email;
Regex rx = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
while (!rx.IsMatch(email = Console.ReadLine())) {
    Console.Write("Digite um email válido:");
}
Console.WriteLine($"Seu email é: {email}");
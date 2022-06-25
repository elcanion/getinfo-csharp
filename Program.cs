Console.Write("Digite seu nome: ");
string? name = Console.ReadLine();
Console.WriteLine($"Olá {name}");
Console.Write("Digite o ano do seu nascimento: ");
int yearOfBirth;
while (!int.TryParse(Console.ReadLine(), out yearOfBirth)) {
    Console.Write("Digite um ano de nascimento válido:");
}
int age = DateTime.Now.Year - yearOfBirth;
Console.Write($"Você nasceu em {yearOfBirth} e você tem {age} anos");
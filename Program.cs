Console.Write("Digite seu nome: ");
string? name = Console.ReadLine();
Console.WriteLine($"Olá {name}");
Console.Write("Digite o ano do seu nascimento: ");
int year;
while (!int.TryParse(Console.ReadLine(), out year)) {
    Console.Write("Digite um ano de nascimento válido:");
}

Console.Write($"Voce nasceu em {year}");
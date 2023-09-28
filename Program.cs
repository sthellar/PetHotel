// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Espécie: ");
string especie = Console.ReadLine()!;
Console.Write("Raça: ");
string raca = Console.ReadLine()!;
Console.Write("Nome do pet: ");
string Nome = Console.ReadLine()!;
Console.Write("Idade: ");
string idade = Console.ReadLine()!;
Console.Write("Cor da pelagem: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.Write("Pet Hotel \"Nem um pio\"");
Console.WriteLine("                  |");
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.Write(" | Raça: ");
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pelo nome de: ");
Console.Write(Nome.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.WriteLine("    |");
Console.Write("| Idade: ");
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.Write(" | Pelagem/cor: ");
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.WriteLine(" |");
Console.Write("+=========================================================+");

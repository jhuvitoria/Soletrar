Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Soletrar");
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("DIGITE UMA PALAVRA: ");
Console.ResetColor();
string PALAVRA = Console.ReadLine()!;
var caracteres = PALAVRA.ToCharArray();
string palavraSoletrada = String.Join('-', caracteres).ToUpper(); 
Console.WriteLine($"\nResultado: {palavraSoletrada}");








int n = 1;

while (n <= 100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{n} ");
    n = n + 1;
    Console.ResetColor();
}

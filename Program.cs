Console.Write("Informe a primeira pontuação: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Informe a segunda pontuação: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Informe a terceira pontuação: ");
int c = int.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{
    int maior = Math.Max(a, Math.Max(b, c));
    Console.WriteLine($"Maior pontuação: {maior}");
}
Console.Write("Informe o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (n2 > n1)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
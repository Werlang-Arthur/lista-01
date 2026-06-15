double soma = 0;

Console.Write("Informe o primeiro valor: ");
soma += double.Parse(Console.ReadLine());

Console.Write("Informe o segundo valor: ");
soma += double.Parse(Console.ReadLine());

Console.Write("Informe o terceiro valor: ");
soma += double.Parse(Console.ReadLine());

Console.Write("Informe o quarto valor: ");
soma += double.Parse(Console.ReadLine());

Console.Write("Informe o quinto valor: ");
soma += double.Parse(Console.ReadLine());

Console.WriteLine($"Soma dos valores: {soma}");
Console.WriteLine($"Média dos valores: {soma / 5}");
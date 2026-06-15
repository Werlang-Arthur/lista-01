Console.Write("Informe a quantidade de clientes atendidos: ");
int clientes = int.Parse(Console.ReadLine());

int total = 0;

for (int i = 1; i <= clientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine());

    total += tempo;
}

double media = (double)total / clientes;

Console.WriteLine($"Tempo total de atendimento: {total} minutos");
Console.WriteLine($"Tempo médio por cliente: {media} minutos");
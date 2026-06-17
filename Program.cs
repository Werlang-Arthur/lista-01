using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);

        if (delta < 0)
        {
            Console.WriteLine("Não existem raízes reais.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"Delta = {delta}");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}
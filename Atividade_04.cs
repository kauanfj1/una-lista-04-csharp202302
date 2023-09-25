using System;

class Atividade_04
{
    static void Main()
    {
        int quantidadeNumeros = 5;
        double soma = 0;

        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            soma += numero;
        }

        double media = soma / quantidadeNumeros;

        Console.WriteLine($"Soma dos números: {soma}");
        Console.WriteLine($"Média dos números: {media}");
    }
}


using System;

class Atividade_06
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            int temp = numero1;
            numero1 = numero2;
            numero2 = temp;
        }

        Console.WriteLine("Números inteiros no intervalo entre " + numero1 + " e " + numero2 + ":");

        for (int i = numero1 + 1; i < numero2; i++)
        {
            Console.WriteLine(i);
        }
    }
}
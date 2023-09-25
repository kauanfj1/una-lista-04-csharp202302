using System;

class Atividade_07
{
    static void Main(string[] args)
    {
        int numerosPares = 0;
        int numerosImpares = 0;
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o número " + i + ": ");
            int numero = int.Parse(Console.ReadLine());
            
            if (numero % 2 == 0)
            {
                numerosPares++;
            }
            else
            {
                numerosImpares++;
            }
        }
        
        Console.WriteLine("Quantidade de números pares: " + numerosPares);
        Console.WriteLine("Quantidade de números ímpares: " + numerosImpares);
    }
}
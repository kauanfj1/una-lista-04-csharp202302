using System;
class Atividade_01
{
    static void Main(string[] args)
    {
        double result;
        do
        {
            Console.Write("Informe uma nota entre zero e dez: ");
            result = double.Parse(Console.ReadLine());
            if (result < 0 || result > 10)
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        } while (result < 0 || result > 10);
        
        Console.WriteLine("Valor válido inserido: " + result);
    }
}

 
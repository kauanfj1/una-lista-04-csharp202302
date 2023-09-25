using System;

class Atividade_03
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        double salario;
        char sexo;
        char estadoCivil;
        
        do
        {
            Console.Write("Digite o nome (maior que 3 caracteres): ");
            nome = Console.ReadLine();
            
            Console.Write("Digite a idade (entre 0 e 150): ");
            idade = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o salário (maior que zero): ");
            salario = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o sexo ('f' ou 'm'): ");
            sexo = char.Parse(Console.ReadLine());
            
            Console.Write("Digite o estado civil ('s', 'c', 'v', 'd'): ");
            estadoCivil = char.Parse(Console.ReadLine());
            
            if (nome.Length <= 3)
            {
                Console.WriteLine("Nome inválido. Tente novamente.");
            }
            
            if (idade < 0 || idade > 150)
            {
                Console.WriteLine("Idade inválida. Tente novamente.");
            }
            
            if (salario <= 0)
            {
                Console.WriteLine("Salário inválido. Tente novamente.");
            }
            
            if (sexo != 'f' && sexo != 'm')
            {
                Console.WriteLine("Sexo inválido. Tente novamente.");
            }
            
            if (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
            {
                Console.WriteLine("Estado civil inválido. Tente novamente.");
            }
        } while (nome.Length <= 3 || idade < 0 || idade > 150 || salario <= 0 || sexo != 'f' && sexo != 'm' || estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');
        
        Console.WriteLine("Informações válidas inseridas:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Estado Civil: " + estadoCivil);
    }
}
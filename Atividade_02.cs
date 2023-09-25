using System;

class Atividade_02
{
    static void Main(string[] args)
    {
        string nome;
        string senha;
        
        do
        {
            Console.Write("Digite seu nome de usuário: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();
            
            if (nome == senha)
            {
                Console.WriteLine("Erro: A senha não deve ser igual ao nome.");
            }
        } while (nome == senha);
        
        Console.WriteLine("Cadastro aprovado.");
    }
}

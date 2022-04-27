using System;

namespace Pessoa_fazAniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Pessoa pessoa1 = new Pessoa();
            pessoa1.setNome("Tiago");
            pessoa1.setIdade(20);
            Console.WriteLine("Olá, " + pessoa1.getNome() + "!");
            Console.WriteLine("Você tem " + pessoa1.getIdade() + " anos!");
            Console.WriteLine("\n Mas vamos mudar isso! Pronto para acelerar o tempo?");
            resposta = Console.ReadLine();
            Console.WriteLine("\n Ótimo! Vamos nessa:");
            pessoa1.FazAniversario();
            pessoa1.FazAniversario();
            pessoa1.FazAniversario();

            Console.WriteLine("\n Como você se sente? Veja como você mudou!");
            Console.WriteLine("Você tem " + pessoa1.getIdade() + " anos!");
            
            
        }
    }
}

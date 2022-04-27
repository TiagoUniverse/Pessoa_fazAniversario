using System;

namespace Pessoa_fazAniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.setNome("Tiago");
            Console.WriteLine("Olá, " + pessoa1.getNome() + "!");
        }
    }
}

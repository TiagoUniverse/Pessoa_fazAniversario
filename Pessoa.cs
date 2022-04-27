using System;

namespace Pessoa_fazAniversario
{
    class Pessoa
    {
        private string nome;
        private int idade;


        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void FazAniversario()
        {
            Console.WriteLine(getNome() + " tem " + getIdade() + " anos ");
        }

    }
}

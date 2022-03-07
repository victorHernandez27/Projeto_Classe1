using System;

namespace Projeto_Classe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Jorge",30); //Instancia de um Objeto Pessoa
            Console.WriteLine("Os dados da pessoa criada são:");
            Console.WriteLine(p1.getNome());
            Console.WriteLine(p1.getIdade());

            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Os dados da pessoa criada são:");
            Console.WriteLine(pessoa.getNome());
            Console.WriteLine(pessoa.getIdade());

            pessoa.setNome("Pestana");
            pessoa.setIdade(38);
            //pessoa.nome = "Fabio";
            //pessoa.idade = 50;

            Console.WriteLine("Os dados da pessoa criada são:");
            Console.WriteLine(pessoa.getNome());
            Console.WriteLine(pessoa.getIdade());

            Endereco e1 = new Endereco("Araraquara", "Rua dos Bobos", 0);

            Pessoa p2 = new Pessoa("Maria", 20, e1); //Instancia de um Objeto Pessoa
            Console.WriteLine("Os dados da pessoa p2 criada são:");
            Console.WriteLine(p2.getNome());
            Console.WriteLine(p2.getIdade());
            Console.WriteLine(p2.endereco.ToString());
        }
    }
}

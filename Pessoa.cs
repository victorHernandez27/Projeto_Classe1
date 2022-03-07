using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe1
{
    internal class Pessoa
    {
         string nome;
         int idade;
         public Endereco endereco;

        public Pessoa()
        {
            nome = "John Doe";
            idade = 0;  
            Console.WriteLine("Criou uma pessoa");    
        } 

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
    }
}

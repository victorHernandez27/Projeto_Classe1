using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe1
{
    internal class Endereco
    {
        public string Localidade { get; set; }
        public string Logradouro{ get; set; }
        public int numero { get; set; }

        public override string ToString()
        {
            return "O Endereco em: \nCidade:" + Localidade + "\n Logradouro:"+Logradouro+"\n nº:"+numero;
        }

        public Endereco(string Localidade, string Logradouro, int numero)
        {
            this.Localidade = Localidade;
            this.Logradouro = Logradouro;
            this.numero = numero;
        }
    }
}

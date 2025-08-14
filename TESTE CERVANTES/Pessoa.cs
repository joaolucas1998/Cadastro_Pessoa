using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_CERVANTES
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(int id, string nome, string cpf, int idade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }

        public int Id { get; set; }
       
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Idade { get; set; }
    }
}

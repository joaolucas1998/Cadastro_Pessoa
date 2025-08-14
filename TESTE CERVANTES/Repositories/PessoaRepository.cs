using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_CERVANTES.Repositories
{ 
    public class PessoaRepository
    {
        public void Insert(Pessoa pessoa)
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetDbConnection();
            conexao.Execute("INSERT INTO PESSOA (NOME,CPF,IDADE) VALUES(@nome,@cpf,@idade);",
                new
                {
                    nome = pessoa.Nome,
                    cpf = pessoa.Cpf,
                    idade = pessoa.Idade,
                });
        }

        public void Update(Pessoa pessoa)
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetDbConnection();
            conexao.Execute("UPDATE PESSOA SET NOME = @nome, CPF = @cpf, IDADE = @idade WHERE ID = @id;",
                new
                {
                    nome = pessoa.Nome,
                    cpf = pessoa.Cpf,
                    idade = pessoa.Idade,
                    id = pessoa.Id

                });
        }

        public void Delete(int id)
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetDbConnection();
            conexao.Execute("DELETE FROM PESSOA WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Pessoa BuscarPessoaPeloId(int id)    
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetDbConnection();
            return conexao.QueryFirstOrDefault<Pessoa>(@"SELECT * FROM PESSOA WHERE ID = @id",
                new { id });
        }

        public IEnumerable<Pessoa> BuscarTodasPessoas()
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetDbConnection();
            return conexao.Query<Pessoa>(@"SELECT * FROM PESSOA");
        }


    }
}
 
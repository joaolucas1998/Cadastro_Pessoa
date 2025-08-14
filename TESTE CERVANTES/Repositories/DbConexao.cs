using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_CERVANTES.Repositories
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;
        public DbConexao()
        {
            connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=qwe123;Database=postgres");
        }

        public IDbConnection GetDbConnection()
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}

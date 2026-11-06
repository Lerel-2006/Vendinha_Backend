using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace Vendas.Services
{
    public class Conexao
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=root123";


        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(connectionString);

        }
    }
}

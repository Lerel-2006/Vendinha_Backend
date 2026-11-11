using Vendas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Vendas.Models;
using Npgsql;

namespace Vendas.Services
{
    public class DividaService
    {
        private readonly Conexao conexao = new Conexao();

        public List<Dividas> Consultar()
        {
            return dividas;
        }

        public bool Criar(Dividas divida)
        {
            var contexto = new ValidationContext(divida);
            var resultados = new List<ValidationResult>();

            bool valido = Validator.TryValidateObject(
                divida,
                contexto,
                resultados,
                true
            );

            if (!valido || divida.Valor <= 0)
            {
                return false;
            }

            using (var banco = conexao.Conectar())
            {
                banco.Open();

                string query = @"INSERT INTO dividas
                (id_cliente, nome_divida, valor, paga, data_criacao, data_pagamento)
                VALUES 
                (@id_cliente, @nome_divida, @valor, @paga, @data_criacao, @data_pagamento)";


                using (var comando = new NpgsqlCommand(query, banco))
                {
                    comando.Parameters.AddWithValue("@id_cliente", divida.IdCliente);
                    comando.Parameters.AddWithValue("@nome_divida", divida.NomeDaDivida);
                    comando.Parameters.AddWithValue("@valor", divida.Valor);
                    comando.Parameters.AddWithValue("@paga", divida.Situacao);
                    comando.Parameters.AddWithValue("@data_criacao", divida.DataDeCriacao);
                    comando.Parameters.AddWithValue("@data_pagamento", (object?)divida.DataDePagamento ?? DBNull.Value);
                    comando.ExecuteNonQuery();
                }
                return true;
            }
        }

        public List<Dividas> ConsultarPorCliente(int idCliente)
        {
            return dividas
                .Where(d => d.IdCliente == idCliente)
                .ToList();
        }

        public Dividas? ConsultarPorId(int id)
        {
            return dividas.FirstOrDefault(d => d.Id == id);
        }

        public bool RegistrarPagamento(int id)
        {
            Dividas? divida = ConsultarPorId(id);

            if (divida == null || divida.Situacao)
            {
                return false;
            }

            divida.Situacao = true;
            divida.DataDePagamento = DateTime.Now;

            return true;
        }
    }
}

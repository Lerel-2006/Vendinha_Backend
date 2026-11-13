using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vendas.Models
{
    public class Dividas
    {

        public int Id { get; set; }

        [Required, StringLength (100)]
        public string NomeDaDivida { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public bool Situacao { get; set; } = false;

        public DateTime DataDeCriacao { get; set; } = DateTime.Now;

        public DateTime? DataDePagamento { get; set; }

        [Required]
        public int IdCliente { get; set; }

        public Dividas(string nomeDaDivida, decimal valor, bool situacao, DateTime dataDeCriacao, DateTime? dataDePagamento = null)
        {
            NomeDaDivida = nomeDaDivida;
            Valor = valor;
            Situacao = situacao;
            DataDeCriacao = dataDeCriacao;
            DataDePagamento = dataDePagamento;
        }

        public virtual void PrintDados()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome da Dívida: {NomeDaDivida}");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Situação: {Situacao}");
            Console.WriteLine($"Data de Criação: {DataDeCriacao}");
            if (DataDePagamento.HasValue)
            {
                Console.WriteLine($"Data de Pagamento: {DataDePagamento.Value}");
            }
        }



    }
}

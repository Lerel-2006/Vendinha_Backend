using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vendas.Models
{
    public class Divida
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

        public int IdCliente { get; set; }

        public Divida(string nomeDaDivida, decimal valor, bool situacao, DateTime dataDeCriacao, DateTime? dataDePagamento)
        {
            NomeDaDivida = nomeDaDivida;
            Valor = valor;
            Situacao = situacao;
            DataDeCriacao = dataDeCriacao;
            DataDePagamento = dataDePagamento;
        }

        public virtual void PrintDados()
        {
            Console.WriteLine(Id);
            Console.WriteLine(NomeDaDivida);
            Console.WriteLine(Valor);
            Console.WriteLine(Situacao);
            Console.WriteLine(DataDeCriacao);
            if (DataDePagamento.HasValue)
            {
                Console.WriteLine(DataDePagamento.Value);
            }
        }


    }
}

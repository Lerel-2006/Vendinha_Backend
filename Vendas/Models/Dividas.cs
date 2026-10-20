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


    }
}

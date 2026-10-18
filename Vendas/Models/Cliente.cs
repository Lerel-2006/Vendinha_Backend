using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vendas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        public int Idade =>
            DateTime.Now.Year - DataNascimento.Year - (DateTime.Now.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);
    }
}

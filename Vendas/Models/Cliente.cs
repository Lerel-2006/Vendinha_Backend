using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        private string? email;

        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string? Email
        {
            get { return email; }
            set
            {
                email = value?.ToLower().Trim();
            }
        }

        [NotMapped]
        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                var hojeAnoNascimento = hoje.AddYears(-idade);

                if(DataNascimento > hojeAnoNascimento)
                {
                    idade--;
                }
                return idade;

            }
        }
        public Cliente(string nome, string cpf, DateTime dataNascimento, string? email = null)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
        }

        public virtual void PrintDados()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Nome);
            Console.WriteLine(Cpf);
            Console.WriteLine(DataNascimento);
            Console.WriteLine(Email);
            Console.WriteLine(Idade);
        }
    }
}

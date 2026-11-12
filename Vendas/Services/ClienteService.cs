using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vendas.Contexts;
using Vendas.Models;



namespace Vendas.Services
{
    public class ClienteService
    {
        private readonly VendinhaDbContext _context;

        public ClienteService(VendinhaDbContext context)
        {
            _context = context;
        }

        public bool AdicionarCliente(Cliente cliente)
        {
            var contexto = new ValidationContext(cliente);
            var resultados = new List<ValidationResult>();

            bool valido = Validator.TryValidateObject(cliente, contexto, resultados, true);

            if (!valido)
            {
                foreach (var resultado in resultados)
                {
                    Console.WriteLine(resultado.ErrorMessage);
                }
                return false;
            }

            bool cpfExistente = _context.Clientes.Any(c => c.Cpf == cliente.Cpf);
            if (cpfExistente)
            {
                Console.WriteLine("CPF já cadastrado.");
                return false;
            }

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return true;
        }
        public List<Cliente> Consultar()
        {
            return _context.Clientes.ToList();
        }

        public Cliente? ConsultarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = ConsultarPorId(cliente.Id);
            if (clienteExistente != null)
            {
                _context.Entry(clienteExistente).CurrentValues.SetValues(cliente);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeletarCliente(int id)
        {
            var clienteExistente = ConsultarPorId(id);

            if (clienteExistente != null)
            {
                _context.Clientes.Remove(clienteExistente);
                _context.SaveChanges();
                return true;
            }

            return false;
        }


    }
}

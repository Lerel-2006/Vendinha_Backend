using System;
using System.Collections.Generic;
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

        public void AdicionarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
    }
}

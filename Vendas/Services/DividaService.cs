using Vendas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Vendas.Models;
using Vendas.Contexts;  

namespace Vendas.Services
{
    public class DividaService
    {
        private readonly VendinhaDbContext _context;

        public DividaService(VendinhaDbContext context)
        {
            _context = context;
        }

        public List<Dividas> Consultar()
        {
            return _context.Dividas.ToList();
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

            bool clienteExiste = _context.Clientes.Any(c => c.Id == divida.IdCliente);

            if (!clienteExiste)
            {
                return false;
            }

            _context.Dividas.Add(divida);
            _context.SaveChanges();
            return true;
        }

        

        public List<Dividas> ConsultarPorCliente(int idCliente)
        {
            return _context.Dividas
                .Where(d => d.IdCliente == idCliente)
                .ToList();
        }

        public Dividas? ConsultarPorId(int id)
        {
            return _context.Dividas.FirstOrDefault(d => d.Id == id);
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
            _context.SaveChanges();

            return true;
        }
    }
}

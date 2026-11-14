
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Vendas.Contexts;
using Vendas.Models;

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

        public bool AdicionarDivida(Dividas divida)
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

            bool clienteExiste = _context.Clientes
                .Any(c => c.Id == divida.IdCliente);

            if (!clienteExiste)
            {
                return false;
            }

            bool dividaAberta = _context.Dividas
                .Any(d => d.IdCliente == divida.IdCliente && !d.Situacao);

            if (dividaAberta && !divida.Situacao)
            {
                Console.WriteLine("Este cliente já possui uma dívida em aberto.");
                return false;
            }

            _context.Dividas.Add(divida);
            _context.SaveChanges();

            return true;
        }

        public List<Dividas> ConsultarNClientes()
        {
            return _context.Dividas
                .Include(d => d.Cliente)
                .ToList();
        }

        public Dividas? ConsultarPorIdCliente(int id)
        {
            return _context.Dividas
                .Include(d => d.Cliente)
                .FirstOrDefault(d => d.Id == id);
        }

        public List<Dividas> ConsultarPorCliente(int idCliente)
        {
            return _context.Dividas
                .Where(d => d.IdCliente == idCliente)
                .ToList();
        }

        public Dividas? ConsultarPorId(int id)
        {
            return _context.Dividas
                .FirstOrDefault(d => d.Id == id);
        }

        public bool AtualizarDivida(Dividas divida)
        {
            var dividaExistente = ConsultarPorId(divida.Id);

            if (dividaExistente == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(divida.NomeDaDivida) || divida.Valor <= 0)
            {
                return false;
            }

            dividaExistente.NomeDaDivida = divida.NomeDaDivida;
            dividaExistente.Valor = divida.Valor;
            dividaExistente.Situacao = divida.Situacao;
            dividaExistente.DataDePagamento = divida.DataDePagamento;

            _context.SaveChanges();

            return true;
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

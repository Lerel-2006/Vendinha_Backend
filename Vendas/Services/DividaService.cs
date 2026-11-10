
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Vendas.Models;

namespace Vendas.Services
{
    public class DividaService
    {
        private List<Dividas> dividas = new List<Dividas>();

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

            if (!valido)
            {
                return false;
            }

            if (divida.Valor <= 0)
            {
                return false;
            }

            bool possuiDividaAberta = dividas.Any(d =>
                d.IdCliente == divida.IdCliente &&
                d.Situacao == false
            );

            if (possuiDividaAberta)
            {
                return false;
            }

            divida.Id = dividas.Count + 1;

            dividas.Add(divida);

            return true;
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


using Vendas.Models;
using Vendas.Services;
using System.Globalization;

namespace Vendinha.Desktop.Screens
{
    public partial class CadastrarDividas : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        private int idCliente = 0;

        public CadastrarDividas(
            ClienteService clienteService,
            DividaService dividaService)
        {
            this.clienteService = clienteService;
            this.dividaService = dividaService;

            InitializeComponent();
            NomeCliente.ReadOnly = true;
            idbox.TextChanged += idbox_TextChanged;
            Confirmar.Click += btnCadastrar_Click;
            Limpar.Click += btnLimpar_Click;
            Sair.Click += btnSair_Click;


        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(idbox.Text, out int id))
            {
                var cliente = clienteService.ConsultarPorId(id);

                if (cliente != null)
                {
                    NomeCliente.Text = cliente.Nome;
                    idCliente = cliente.Id;
                }
                else
                {
                    NomeCliente.Clear();
                    idCliente = 0;
                }
            }
            else
            {
                NomeCliente.Clear();
                idCliente = 0;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (idCliente == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                return;
            }

            if (string.IsNullOrWhiteSpace(NomeDivida.Text))
            {
                MessageBox.Show("Informe o nome da dívida!");
                return;
            }

            string valorTexto = Valor.Text.Replace("R$", "").Trim();

            bool valorValido = decimal.TryParse(
                valorTexto,
                NumberStyles.Number,
                new CultureInfo("pt-BR"),
                out decimal valor
            );

            if (!valorValido || valor <= 0)
            {
                MessageBox.Show("Informe um valor válido!");
                return;
            }

            var divida = new Dividas(
                NomeDivida.Text,
                valor,
                false,
                DataCriacao.Value.Date
            );

            divida.IdCliente = idCliente;

            var sucesso = dividaService.AdicionarDivida(divida);

            if (sucesso)
            {
                MessageBox.Show("Dívida cadastrada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha no cadastro da dívida! Verifique se o cliente já possui uma dívida em aberto.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            idbox.Clear();
            NomeCliente.Clear();
            NomeDivida.Clear();
            Valor.Clear();

            DataCriacao.Value = DateTime.Today;

            idCliente = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

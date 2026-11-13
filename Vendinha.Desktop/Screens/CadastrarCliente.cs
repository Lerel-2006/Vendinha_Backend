using Vendas.Contexts;
using Vendas.Models;
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class CadastrarCliente : Form
    {
        private readonly ClienteService service;

        public CadastrarCliente(ClienteService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var cliente = new Cliente(
                nomeBox.Text,
                CpfBox.Text,
                DataBox.Value.Date,
                EmailBox.Text

            );

            var sucesso = service.AdicionarCliente(cliente);

            if (sucesso)
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha no cadastro do cliente!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nomeBox.Clear();
            CpfBox.Clear();
            EmailBox.Clear();
            DataBox.Value = DateTime.Today;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

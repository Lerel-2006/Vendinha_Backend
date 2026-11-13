using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class Atualizar : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        public Atualizar(ClienteService clienteService, DividaService dividaService)
        {
            this.clienteService = clienteService;
            this.dividaService = dividaService;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarCliente tela = new AtualizarCliente(clienteService);
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
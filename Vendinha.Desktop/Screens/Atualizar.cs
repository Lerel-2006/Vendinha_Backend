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
            AtualizarDbox.Click -= AtualizarDbox_Click;
            AtualizarDbox.Click -= AtualizarDbox_Click;
            AtualizarDbox.Click += AtualizarDbox_Click;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarCliente tela = new AtualizarCliente(clienteService);
            tela.ShowDialog();
        }

        private void AtualizarDbox_Click(object sender, EventArgs e)
        {
            AtualizarDivida tela = new AtualizarDivida(dividaService);
            tela.ShowDialog();
        }
    }
}
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class CadastrarDividas : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        public CadastrarDividas(
            ClienteService clienteService,
            DividaService dividaService)
        {
            this.clienteService = clienteService;
            this.dividaService = dividaService;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarDividas_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using Vendinha.Desktop.Screens;
using Vendas.Contexts;
using Vendas.Services;


namespace Vendinha.Desktop
{
    public partial class Form1 : Form
    {
        private readonly VendinhaDbContext contexto;
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        public Form1()
        {
            InitializeComponent();

            string conexao = "Host=localhost;Port=5432;Database=vendinha;Username=;Password=root123";

            contexto = new VendinhaDbContext(conexao);

            clienteService = new ClienteService(contexto);
            dividaService = new DividaService(contexto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarCliente tela = new CadastrarCliente(clienteService);
            tela.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastrarDividas tela = new CadastrarDividas(clienteService, dividaService);
            tela.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarExcluir tela = new ConsultarExcluir(clienteService, dividaService);
            tela.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Atualizar tela = new Atualizar(clienteService, dividaService);
            tela.ShowDialog();
        }
    }
}

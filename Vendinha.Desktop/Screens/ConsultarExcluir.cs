
using Vendas.Models;
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class ConsultarExcluir : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        private List<Dividas> dividas = new List<Dividas>();

        private int paginaAtual = 0;
        private int quantidadePorPagina = 10;

        public ConsultarExcluir(ClienteService clienteService, DividaService dividaService)
        {
            this.clienteService = clienteService;
            this.dividaService = dividaService;

            InitializeComponent();

            button1.Click += button1_Click;
            Anterior.Click += Anterior_Click;
            Proximo.Click += Proximo_Click;
            Excluir.Click += Excluir_Click;
            Sair.Click += Sair_Click;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CarregarDados();
        }

        private void CarregarDados()
        {
            paginaAtual = 0;

            dividas = dividaService.ConsultarNClientes();

            CarregarDividas();
        }

        private void CarregarDividas()
        {
            dataGridView1.Rows.Clear();

            int inicio = paginaAtual * quantidadePorPagina;

            var dividasPagina = dividas
                .Skip(inicio)
                .Take(quantidadePorPagina)
                .ToList();

            foreach (var divida in dividasPagina)
            {
                string situacao = divida.Situacao ? "Paga" : "Em aberto";

                dataGridView1.Rows.Add(
                    divida.Id,
                    divida.IdCliente,
                    divida.Cliente.Nome,
                    divida.Cliente.Cpf,
                    divida.Cliente.Email,
                    divida.Cliente.Idade,
                    divida.NomeDaDivida,
                    divida.Valor.ToString("C2"),
                    divida.DataDeCriacao.ToString("dd/MM/yyyy"),
                    divida.DataDePagamento?.ToString("dd/MM/yyyy") ?? "",
                    situacao
                );
            }

            AtualizarTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim().ToLower();

            dividas = dividaService.ConsultarNClientes()
                .Where(d => d.Cliente.Nome.ToLower().Contains(pesquisa))
                .ToList();

            paginaAtual = 0;

            CarregarDividas();
        }

        private void AtualizarTotal()
        {
            var todasDividas = dividaService.Consultar();

            decimal total = todasDividas
                .Where(d => !d.Situacao)
                .Sum(d => d.Valor);

            this.Text = $"Consultar Dívidas - Total em aberto: {total:C2}";
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                paginaAtual--;
                CarregarDividas();
            }
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling(
                (double)dividas.Count / quantidadePorPagina
            );

            if (paginaAtual < totalPaginas - 1)
            {
                paginaAtual++;
                CarregarDividas();
            }
        }

        private void ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            int idCliente = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["IdCliente"].Value
            );

            var dividasCliente = dividaService.ConsultarPorCliente(idCliente);

            if (dividasCliente.Count > 0)
            {
                MessageBox.Show(
                    "Não é possível excluir este cliente, pois ele possui dívidas registradas."
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                bool sucesso = clienteService.DeletarCliente(idCliente);

                if (sucesso)
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o cliente.");
                }
            }
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarExcluir_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

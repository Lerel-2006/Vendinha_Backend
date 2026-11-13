using Vendas.Models;
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class ConsultarExcluir : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        private List<Cliente> clientes = new List<Cliente>();
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
            clientes = clienteService.Consultar();
            paginaAtual = 0;

            CarregarDadosTabela(clientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = clienteService.Consultar(txtPesquisa.Text);

            paginaAtual = 0;
            CarregarDadosTabela(resultado);
        }

        private void CarregarDadosTabela(List<Cliente> lista)
        {
            clientes = lista;

            dataGridView1.Rows.Clear();

            int inicio = paginaAtual * quantidadePorPagina;

            var clientesPagina = clientes
                .Skip(inicio)
                .Take(quantidadePorPagina)
                .ToList();

            foreach (var cliente in clientesPagina)
            {
                var dividas = dividaService.ConsultarPorCliente(cliente.Id);

                var dividaAberta = dividas.FirstOrDefault(d => !d.Situacao);

                var ultimaDivida = dividas
                    .OrderByDescending(d => d.DataDeCriacao)
                    .FirstOrDefault();

                string situacao;
                string valor;
                string dataCriacao;
                string dataPagamento;

                if (dividaAberta != null)
                {
                    situacao = "Em aberto";
                    valor = dividaAberta.Valor.ToString("C2");
                    dataCriacao = dividaAberta.DataDeCriacao.ToString("dd/MM/yyyy");
                    dataPagamento = "";
                }
                else if (ultimaDivida != null)
                {
                    situacao = "Paga";
                    valor = ultimaDivida.Valor.ToString("C2");
                    dataCriacao = ultimaDivida.DataDeCriacao.ToString("dd/MM/yyyy");
                    dataPagamento = ultimaDivida.DataDePagamento?.ToString("dd/MM/yyyy") ?? "";
                }
                else
                {
                    situacao = "Sem dívida";
                    valor = "R$ 0,00";
                    dataCriacao = "";
                    dataPagamento = "";
                }

                dataGridView1.Rows.Add(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Email,
                    cliente.Idade,
                    dividas.Count,
                    valor,
                    dataCriacao,
                    dataPagamento,
                    situacao
                );
            }

            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            var todasDividas = dividaService.Consultar();

            decimal total = todasDividas
                .Where(d => !d.Situacao)
                .Sum(d => d.Valor);

            this.Text = $"Consultar Clientes - Total em aberto: {total:C2}";
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                paginaAtual--;
                CarregarDadosTabela(clientes);
            }
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)clientes.Count / quantidadePorPagina);

            if (paginaAtual < totalPaginas - 1)
            {
                paginaAtual++;
                CarregarDadosTabela(clientes);
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            var dividas = dividaService.ConsultarPorCliente(id);

            if (dividas.Count > 0)
            {
                MessageBox.Show("Não é possível excluir um cliente que possui dívidas registradas.");
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
                bool sucesso = clienteService.DeletarCliente(id);

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
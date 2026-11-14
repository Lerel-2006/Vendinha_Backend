
using Vendas.Models;
using Vendas.Services;
using System.Globalization;

namespace Vendinha.Desktop.Screens
{
    public partial class AtualizarDivida : Form
    {
        private readonly DividaService dividaService;
        private Dividas? dividaAtual;

        public AtualizarDivida(DividaService dividaService)
        {
            this.dividaService = dividaService;

            InitializeComponent();

            IdDividaBox.TextChanged += IdDividaBox_TextChanged;
            Confirmar.Click += Confirmar_Click;
            Voltar.Click += Voltar_Click;

            IdBox.ReadOnly = true;
            NomeBox.ReadOnly = true;

            NomeDivida.ReadOnly = true;
            Valor.ReadOnly = true;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            pickerData.Enabled = false;

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
        }

        private void IdDividaBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdDividaBox.Text))
            {
                dividaAtual = null;
                return;
            }

            if (!int.TryParse(IdDividaBox.Text, out int id))
            {
                dividaAtual = null;
                return;
            }

            dividaAtual = dividaService.ConsultarPorIdCliente(id);

            if (dividaAtual == null)
            {
                IdBox.Clear();
                NomeBox.Clear();
                NomeDivida.Clear();
                Valor.Clear();

                return;
            }

            IdBox.Text = dividaAtual.IdCliente.ToString();
            NomeBox.Text = dividaAtual.Cliente.Nome;
            NomeDivida.Text = dividaAtual.NomeDaDivida;
            Valor.Text = dividaAtual.Valor.ToString("N2");

            checkBox1.Checked = dividaAtual.Situacao;
            checkBox2.Checked = !dividaAtual.Situacao;

            if (dividaAtual.DataDePagamento.HasValue)
            {
                pickerData.Value = dividaAtual.DataDePagamento.Value;
                pickerData.Checked = true;
            }
            else
            {
                pickerData.Value = DateTime.Today;
                pickerData.Checked = false;
            }

            NomeDivida.ReadOnly = false;
            Valor.ReadOnly = false;

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            pickerData.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                pickerData.Enabled = true;
                pickerData.Checked = true;
            }
            else if (!checkBox2.Checked)
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                pickerData.Checked = false;
            }
            else if (!checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (dividaAtual == null)
            {
                MessageBox.Show("Busque uma dívida primeiro!");
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

            dividaAtual.NomeDaDivida = NomeDivida.Text;
            dividaAtual.Valor = valor;
            dividaAtual.Situacao = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                if (!pickerData.Checked)
                {
                    MessageBox.Show("Informe a data de pagamento!");
                    return;
                }

                dividaAtual.DataDePagamento = pickerData.Value.Date;
            }
            else
            {
                dividaAtual.DataDePagamento = null;
            }

            bool sucesso = dividaService.AtualizarDivida(dividaAtual);

            if (sucesso)
            {
                MessageBox.Show("Dívida atualizada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar a dívida!");
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

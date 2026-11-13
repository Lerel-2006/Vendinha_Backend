using Vendas.Models;
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class AtualizarCliente : Form
    {
        private readonly ClienteService service;
        private bool carregando = false;

        public AtualizarCliente(ClienteService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {
            if (carregando)
                return;

            if (int.TryParse(IdBox.Text, out int id))
            {
                var cliente = service.ConsultarPorId(id);

                if (cliente != null)
                {
                    PreencherCampos(cliente);
                }
            }
        }

        
        private void NomeBox_TextChanged(object sender, EventArgs e)
        {
            if (carregando)
                return;

            var cliente = service.ConsultarPorNome(NomeBox.Text);

            if (cliente != null)
            {
                PreencherCampos(cliente);
            }
        }

        
        private void PreencherCampos(Cliente cliente)
        {
            carregando = true;

            IdBox.Text = cliente.Id.ToString();
            NomeBox.Text = cliente.Nome;
            CPFBox.Text = cliente.Cpf;
            EmailBox.Text = cliente.Email ?? "";
            DataBox.Value = cliente.DataNascimento;

            carregando = false;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdBox.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido.");
                return;
            }

            var cliente = new Cliente(
                NomeBox.Text,
                CPFBox.Text,
                DataBox.Value.Date,
                EmailBox.Text
            );

            cliente.Id = id;

            var sucesso = service.AtualizarCliente(cliente);

            if (sucesso)
            {
                MessageBox.Show("Cliente atualizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }
        }

       
        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
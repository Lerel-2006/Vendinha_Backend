using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendas.Services;

namespace Vendinha.Desktop.Screens
{
    public partial class ConsultarExcluir : Form
    {
        private readonly ClienteService clienteService;
        private readonly DividaService dividaService;

        public ConsultarExcluir(ClienteService clienteService, DividaService dividaService)
        {
            this.clienteService = clienteService;
            this.dividaService = dividaService;

            InitializeComponent();
        }

        private void ConsultarExcluir_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

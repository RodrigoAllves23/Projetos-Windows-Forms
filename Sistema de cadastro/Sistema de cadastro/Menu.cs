using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_cadastro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private Form? TelaCadastroCliente;
        private Form? TelaCadastroProduto;
        private Form? TelaCadastroPedido;

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaCadastroCliente == null || TelaCadastroCliente.IsDisposed)
            {
                TelaCadastroCliente = new CadastroCliente();
                TelaCadastroCliente.Show();
            }
            else
            {
                TelaCadastroCliente.BringToFront();
            }
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaCadastroProduto == null || TelaCadastroProduto.IsDisposed)
            {
                TelaCadastroProduto = new Cadastro_de_Produto();
                TelaCadastroProduto.Show();
            }
            else
            {
                TelaCadastroProduto.BringToFront();
            }
        }

        private void cadastroPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaCadastroPedido == null || TelaCadastroPedido.IsDisposed)
            {
                TelaCadastroPedido = new Cadastro_Pedido();
                TelaCadastroPedido.Show();
            }
            else
            {
                TelaCadastroPedido.BringToFront();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostra uma mensagem de confirmação antes de sair
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Fecha toda a aplicação
            }
        }
    }
}

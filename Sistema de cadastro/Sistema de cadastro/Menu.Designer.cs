namespace Sistema_de_cadastro
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroProdutoToolStripMenuItem = new ToolStripMenuItem();
            cadastroPedidoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            historicoPedidoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem, cadastroProdutoToolStripMenuItem, cadastroPedidoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(823, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(235, 42);
            cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            cadastroProdutoToolStripMenuItem.Size = new Size(248, 42);
            cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            cadastroProdutoToolStripMenuItem.Click += cadastroProdutoToolStripMenuItem_Click;
            // 
            // cadastroPedidoToolStripMenuItem
            // 
            cadastroPedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historicoPedidoToolStripMenuItem });
            cadastroPedidoToolStripMenuItem.Name = "cadastroPedidoToolStripMenuItem";
            cadastroPedidoToolStripMenuItem.Size = new Size(234, 42);
            cadastroPedidoToolStripMenuItem.Text = "Cadastro Pedido";
            cadastroPedidoToolStripMenuItem.Click += cadastroPedidoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(79, 42);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // historicoPedidoToolStripMenuItem
            // 
            historicoPedidoToolStripMenuItem.Name = "historicoPedidoToolStripMenuItem";
            historicoPedidoToolStripMenuItem.Size = new Size(327, 46);
            historicoPedidoToolStripMenuItem.Text = "Historico Pedido";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(823, 618);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastroPedidoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem historicoPedidoToolStripMenuItem;
    }
}
namespace Sistema_de_cadastro
{
    partial class Cadastro_de_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Produto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtIdProduto = new TextBox();
            TxtProduto = new TextBox();
            TxtQuantProduto = new TextBox();
            MskPrecoProduto = new MaskedTextBox();
            TxtCodBarrasProduto = new TextBox();
            CmbCategoriaProduto = new ComboBox();
            BtnSalvarProduto = new Button();
            BtnExcluirProduto = new Button();
            BtnAlterarPedido = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26F);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(157, 73);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 0);
            label1.Size = new Size(565, 164);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Produto";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(187, 301);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 365);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 1;
            label3.Text = "Produto";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(157, 472);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 1;
            label4.Text = "Preço";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(103, 418);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 1;
            label5.Text = "Quantidade";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(538, 418);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 1;
            label6.Text = "Categoria";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(538, 472);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 1;
            label7.Text = "Codigo de Barras";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtIdProduto
            // 
            TxtIdProduto.BackColor = Color.LightBlue;
            TxtIdProduto.BorderStyle = BorderStyle.FixedSingle;
            TxtIdProduto.Enabled = false;
            TxtIdProduto.Font = new Font("Segoe UI", 10F);
            TxtIdProduto.Location = new Point(224, 301);
            TxtIdProduto.MaxLength = 6;
            TxtIdProduto.Name = "TxtIdProduto";
            TxtIdProduto.Size = new Size(150, 34);
            TxtIdProduto.TabIndex = 0;
            TxtIdProduto.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtProduto
            // 
            TxtProduto.BackColor = Color.LightBlue;
            TxtProduto.BorderStyle = BorderStyle.FixedSingle;
            TxtProduto.Font = new Font("Segoe UI", 10F);
            TxtProduto.Location = new Point(224, 365);
            TxtProduto.MaxLength = 50;
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(150, 34);
            TxtProduto.TabIndex = 1;
            // 
            // TxtQuantProduto
            // 
            TxtQuantProduto.BackColor = Color.LightBlue;
            TxtQuantProduto.BorderStyle = BorderStyle.FixedSingle;
            TxtQuantProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantProduto.Location = new Point(225, 418);
            TxtQuantProduto.MaxLength = 10;
            TxtQuantProduto.Name = "TxtQuantProduto";
            TxtQuantProduto.Size = new Size(150, 34);
            TxtQuantProduto.TabIndex = 2;
            // 
            // MskPrecoProduto
            // 
            MskPrecoProduto.BackColor = Color.LightBlue;
            MskPrecoProduto.BorderStyle = BorderStyle.FixedSingle;
            MskPrecoProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MskPrecoProduto.Location = new Point(224, 472);
            MskPrecoProduto.Mask = "$ ";
            MskPrecoProduto.Name = "MskPrecoProduto";
            MskPrecoProduto.Size = new Size(150, 34);
            MskPrecoProduto.TabIndex = 4;
            // 
            // TxtCodBarrasProduto
            // 
            TxtCodBarrasProduto.BackColor = Color.LightBlue;
            TxtCodBarrasProduto.BorderStyle = BorderStyle.FixedSingle;
            TxtCodBarrasProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCodBarrasProduto.Location = new Point(706, 472);
            TxtCodBarrasProduto.MaxLength = 13;
            TxtCodBarrasProduto.Name = "TxtCodBarrasProduto";
            TxtCodBarrasProduto.Size = new Size(150, 34);
            TxtCodBarrasProduto.TabIndex = 5;
            // 
            // CmbCategoriaProduto
            // 
            CmbCategoriaProduto.BackColor = Color.LightBlue;
            CmbCategoriaProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoriaProduto.FlatStyle = FlatStyle.Flat;
            CmbCategoriaProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCategoriaProduto.FormattingEnabled = true;
            CmbCategoriaProduto.Items.AddRange(new object[] { "Roupas", "Calçados", "Eletroeletrônicos", "Casa e Decoração", "Alimentos" });
            CmbCategoriaProduto.Location = new Point(641, 420);
            CmbCategoriaProduto.Name = "CmbCategoriaProduto";
            CmbCategoriaProduto.Size = new Size(215, 36);
            CmbCategoriaProduto.TabIndex = 3;
            // 
            // BtnSalvarProduto
            // 
            BtnSalvarProduto.BackColor = Color.Blue;
            BtnSalvarProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvarProduto.ForeColor = Color.White;
            BtnSalvarProduto.Location = new Point(434, 571);
            BtnSalvarProduto.Name = "BtnSalvarProduto";
            BtnSalvarProduto.Size = new Size(160, 74);
            BtnSalvarProduto.TabIndex = 6;
            BtnSalvarProduto.Text = "&Salvar";
            BtnSalvarProduto.UseVisualStyleBackColor = false;
            // 
            // BtnExcluirProduto
            // 
            BtnExcluirProduto.BackColor = Color.Blue;
            BtnExcluirProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExcluirProduto.ForeColor = Color.White;
            BtnExcluirProduto.Location = new Point(687, 571);
            BtnExcluirProduto.Name = "BtnExcluirProduto";
            BtnExcluirProduto.Size = new Size(154, 74);
            BtnExcluirProduto.TabIndex = 6;
            BtnExcluirProduto.Text = "Excluir";
            BtnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarPedido
            // 
            BtnAlterarPedido.BackColor = Color.Blue;
            BtnAlterarPedido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAlterarPedido.ForeColor = Color.White;
            BtnAlterarPedido.Location = new Point(157, 571);
            BtnAlterarPedido.Name = "BtnAlterarPedido";
            BtnAlterarPedido.Size = new Size(190, 74);
            BtnAlterarPedido.TabIndex = 6;
            BtnAlterarPedido.Text = "Alterar Produto";
            BtnAlterarPedido.UseVisualStyleBackColor = false;
            // 
            // Cadastro_de_Produto
            // 
            AcceptButton = BtnSalvarProduto;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(924, 722);
            Controls.Add(BtnExcluirProduto);
            Controls.Add(BtnAlterarPedido);
            Controls.Add(BtnSalvarProduto);
            Controls.Add(CmbCategoriaProduto);
            Controls.Add(MskPrecoProduto);
            Controls.Add(TxtCodBarrasProduto);
            Controls.Add(TxtQuantProduto);
            Controls.Add(TxtProduto);
            Controls.Add(TxtIdProduto);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_de_Produto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro_de_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtIdProduto;
        private TextBox TxtProduto;
        private TextBox TxtQuantProduto;
        private MaskedTextBox MskPrecoProduto;
        private TextBox TxtCodBarrasProduto;
        private ComboBox CmbCategoriaProduto;
        private Button BtnSalvarProduto;
        private Button BtnExcluirProduto;
        private Button BtnAlterarPedido;
    }
}
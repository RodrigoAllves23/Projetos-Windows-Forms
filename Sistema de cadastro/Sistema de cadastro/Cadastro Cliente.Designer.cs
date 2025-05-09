namespace Sistema_de_cadastro
{
    partial class CadastroCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TxtIdCliente = new TextBox();
            TxtNomeCliente = new TextBox();
            TxtEnderecoCliente = new TextBox();
            TxtEndNumCliente = new TextBox();
            TxtBairroCliente = new TextBox();
            TxtMunicipioCliente = new TextBox();
            TxtEstadoCliente = new TextBox();
            MskCpfCliente = new MaskedTextBox();
            MskCepCliente = new MaskedTextBox();
            CmbSexoCliente = new ComboBox();
            BtnSalvarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26F);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(152, 80);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 20, 0);
            label1.Size = new Size(621, 96);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(192, 280);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 342);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(157, 401);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 2;
            label4.Text = "Nome";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(169, 471);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 2;
            label5.Text = "Sexo";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(130, 528);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 2;
            label6.Text = "Endereço";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(670, 528);
            label7.Name = "label7";
            label7.Size = new Size(84, 28);
            label7.TabIndex = 2;
            label7.Text = "Número";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(159, 581);
            label8.Name = "label8";
            label8.Size = new Size(64, 28);
            label8.TabIndex = 2;
            label8.Text = "Bairro";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(709, 581);
            label9.Name = "label9";
            label9.Size = new Size(45, 28);
            label9.TabIndex = 2;
            label9.Text = "CEP";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(123, 639);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 2;
            label10.Text = "Município";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(683, 639);
            label11.Name = "label11";
            label11.Size = new Size(71, 28);
            label11.TabIndex = 2;
            label11.Text = "Estado";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.BackColor = Color.LightBlue;
            TxtIdCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtIdCliente.Enabled = false;
            TxtIdCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIdCliente.Location = new Point(229, 280);
            TxtIdCliente.MaxLength = 6;
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(150, 34);
            TxtIdCliente.TabIndex = 0;
            TxtIdCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtNomeCliente
            // 
            TxtNomeCliente.BackColor = Color.LightBlue;
            TxtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNomeCliente.Location = new Point(229, 398);
            TxtNomeCliente.MaxLength = 70;
            TxtNomeCliente.Name = "TxtNomeCliente";
            TxtNomeCliente.Size = new Size(658, 34);
            TxtNomeCliente.TabIndex = 2;
            // 
            // TxtEnderecoCliente
            // 
            TxtEnderecoCliente.BackColor = Color.LightBlue;
            TxtEnderecoCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtEnderecoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEnderecoCliente.Location = new Point(229, 526);
            TxtEnderecoCliente.MaxLength = 70;
            TxtEnderecoCliente.Name = "TxtEnderecoCliente";
            TxtEnderecoCliente.Size = new Size(435, 34);
            TxtEnderecoCliente.TabIndex = 4;
            // 
            // TxtEndNumCliente
            // 
            TxtEndNumCliente.BackColor = Color.LightBlue;
            TxtEndNumCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtEndNumCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEndNumCliente.Location = new Point(760, 526);
            TxtEndNumCliente.MaxLength = 70;
            TxtEndNumCliente.Name = "TxtEndNumCliente";
            TxtEndNumCliente.Size = new Size(127, 34);
            TxtEndNumCliente.TabIndex = 5;
            // 
            // TxtBairroCliente
            // 
            TxtBairroCliente.BackColor = Color.LightBlue;
            TxtBairroCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtBairroCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBairroCliente.Location = new Point(229, 579);
            TxtBairroCliente.MaxLength = 50;
            TxtBairroCliente.Name = "TxtBairroCliente";
            TxtBairroCliente.Size = new Size(435, 34);
            TxtBairroCliente.TabIndex = 6;
            // 
            // TxtMunicipioCliente
            // 
            TxtMunicipioCliente.BackColor = Color.LightBlue;
            TxtMunicipioCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtMunicipioCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMunicipioCliente.Location = new Point(229, 633);
            TxtMunicipioCliente.MaxLength = 50;
            TxtMunicipioCliente.Name = "TxtMunicipioCliente";
            TxtMunicipioCliente.Size = new Size(435, 34);
            TxtMunicipioCliente.TabIndex = 8;
            // 
            // TxtEstadoCliente
            // 
            TxtEstadoCliente.BackColor = Color.LightBlue;
            TxtEstadoCliente.BorderStyle = BorderStyle.FixedSingle;
            TxtEstadoCliente.CharacterCasing = CharacterCasing.Upper;
            TxtEstadoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEstadoCliente.Location = new Point(760, 633);
            TxtEstadoCliente.MaxLength = 2;
            TxtEstadoCliente.Name = "TxtEstadoCliente";
            TxtEstadoCliente.Size = new Size(127, 34);
            TxtEstadoCliente.TabIndex = 9;
            TxtEstadoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // MskCpfCliente
            // 
            MskCpfCliente.BackColor = Color.LightBlue;
            MskCpfCliente.BorderStyle = BorderStyle.FixedSingle;
            MskCpfCliente.Location = new Point(229, 339);
            MskCpfCliente.Mask = "000.000.000-00";
            MskCpfCliente.Name = "MskCpfCliente";
            MskCpfCliente.Size = new Size(150, 31);
            MskCpfCliente.TabIndex = 1;
            // 
            // MskCepCliente
            // 
            MskCepCliente.BackColor = Color.LightBlue;
            MskCepCliente.BorderStyle = BorderStyle.FixedSingle;
            MskCepCliente.Location = new Point(760, 582);
            MskCepCliente.Mask = "00000-000";
            MskCepCliente.Name = "MskCepCliente";
            MskCepCliente.Size = new Size(127, 31);
            MskCepCliente.TabIndex = 7;
            // 
            // CmbSexoCliente
            // 
            CmbSexoCliente.BackColor = Color.LightBlue;
            CmbSexoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSexoCliente.FlatStyle = FlatStyle.Flat;
            CmbSexoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbSexoCliente.FormattingEnabled = true;
            CmbSexoCliente.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            CmbSexoCliente.Location = new Point(229, 471);
            CmbSexoCliente.Name = "CmbSexoCliente";
            CmbSexoCliente.Size = new Size(182, 36);
            CmbSexoCliente.TabIndex = 3;
            // 
            // BtnSalvarCliente
            // 
            BtnSalvarCliente.BackColor = Color.Blue;
            BtnSalvarCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvarCliente.ForeColor = Color.White;
            BtnSalvarCliente.Image = (Image)resources.GetObject("BtnSalvarCliente.Image");
            BtnSalvarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalvarCliente.Location = new Point(391, 726);
            BtnSalvarCliente.Name = "BtnSalvarCliente";
            BtnSalvarCliente.Padding = new Padding(5, 0, 10, 0);
            BtnSalvarCliente.Size = new Size(186, 73);
            BtnSalvarCliente.TabIndex = 10;
            BtnSalvarCliente.Text = "&Salvar";
            BtnSalvarCliente.TextAlign = ContentAlignment.MiddleRight;
            BtnSalvarCliente.UseVisualStyleBackColor = false;
            // 
            // CadastroCliente
            // 
            AcceptButton = BtnSalvarCliente;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1001, 881);
            Controls.Add(BtnSalvarCliente);
            Controls.Add(CmbSexoCliente);
            Controls.Add(MskCepCliente);
            Controls.Add(MskCpfCliente);
            Controls.Add(TxtEstadoCliente);
            Controls.Add(TxtEndNumCliente);
            Controls.Add(TxtMunicipioCliente);
            Controls.Add(TxtBairroCliente);
            Controls.Add(TxtEnderecoCliente);
            Controls.Add(TxtNomeCliente);
            Controls.Add(TxtIdCliente);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Cliente";
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
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TxtIdCliente;
        private TextBox TxtNomeCliente;
        private TextBox TxtEnderecoCliente;
        private TextBox TxtEndNumCliente;
        private TextBox TxtBairroCliente;
        private TextBox TxtMunicipioCliente;
        private TextBox TxtEstadoCliente;
        private MaskedTextBox MskCpfCliente;
        private MaskedTextBox MskCepCliente;
        private ComboBox CmbSexoCliente;
        private Button BtnSalvarCliente;
    }
}

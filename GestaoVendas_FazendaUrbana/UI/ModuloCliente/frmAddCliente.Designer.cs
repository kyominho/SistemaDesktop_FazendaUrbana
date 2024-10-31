namespace GestaoVendas_FazendaUrbana
{
    partial class frmAddCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.mskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouroCliente = new System.Windows.Forms.TextBox();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.txtNumeroLCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.lblCepCliente = new System.Windows.Forms.Label();
            this.lblLogradouroCliente = new System.Windows.Forms.Label();
            this.lblNumeroLogradouroC = new System.Windows.Forms.Label();
            this.mskCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(117, 55);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(339, 33);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(117, 108);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(339, 33);
            this.txtEmailCliente.TabIndex = 2;
            this.txtEmailCliente.Leave += new System.EventHandler(this.txtEmailCliente_Leave);
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidadeCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(120, 201);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(336, 33);
            this.txtCidadeCliente.TabIndex = 4;
            this.txtCidadeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidadeCliente_KeyPress);
            // 
            // mskTelefoneCliente
            // 
            this.mskTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTelefoneCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneCliente.Location = new System.Drawing.Point(161, 247);
            this.mskTelefoneCliente.Mask = "(99) 0000-00000";
            this.mskTelefoneCliente.Name = "mskTelefoneCliente";
            this.mskTelefoneCliente.Size = new System.Drawing.Size(221, 33);
            this.mskTelefoneCliente.TabIndex = 5;
            this.mskTelefoneCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefoneCliente_MaskInputRejected);
            // 
            // txtLogradouroCliente
            // 
            this.txtLogradouroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouroCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouroCliente.Location = new System.Drawing.Point(161, 340);
            this.txtLogradouroCliente.Name = "txtLogradouroCliente";
            this.txtLogradouroCliente.Size = new System.Drawing.Size(291, 33);
            this.txtLogradouroCliente.TabIndex = 7;
            // 
            // cmbUF
            // 
            this.cmbUF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUF.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUF.Location = new System.Drawing.Point(120, 155);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(107, 38);
            this.cmbUF.TabIndex = 9;
            // 
            // txtNumeroLCliente
            // 
            this.txtNumeroLCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroLCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroLCliente.Location = new System.Drawing.Point(239, 382);
            this.txtNumeroLCliente.Name = "txtNumeroLCliente";
            this.txtNumeroLCliente.Size = new System.Drawing.Size(104, 33);
            this.txtNumeroLCliente.TabIndex = 10;
            this.txtNumeroLCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroLCliente_KeyPress);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(26, 58);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(69, 30);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(26, 111);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(63, 30);
            this.lblEmailCliente.TabIndex = 12;
            this.lblEmailCliente.Text = "Email:";
            // 
            // lblUF
            // 
            this.lblUF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(26, 158);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(37, 30);
            this.lblUF.TabIndex = 13;
            this.lblUF.Text = "UF:";
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(26, 201);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(78, 30);
            this.lblCidadeCliente.TabIndex = 14;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(26, 247);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(91, 30);
            this.lblTelefoneCliente.TabIndex = 15;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(161, 463);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(161, 44);
            this.btnCadastrarCliente.TabIndex = 16;
            this.btnCadastrarCliente.Text = "GRAVAR";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // lblCepCliente
            // 
            this.lblCepCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCepCliente.AutoSize = true;
            this.lblCepCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCepCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCliente.Location = new System.Drawing.Point(26, 296);
            this.lblCepCliente.Name = "lblCepCliente";
            this.lblCepCliente.Size = new System.Drawing.Size(49, 30);
            this.lblCepCliente.TabIndex = 17;
            this.lblCepCliente.Text = "CEP:";
            // 
            // lblLogradouroCliente
            // 
            this.lblLogradouroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouroCliente.AutoSize = true;
            this.lblLogradouroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblLogradouroCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouroCliente.Location = new System.Drawing.Point(26, 340);
            this.lblLogradouroCliente.Name = "lblLogradouroCliente";
            this.lblLogradouroCliente.Size = new System.Drawing.Size(113, 30);
            this.lblLogradouroCliente.TabIndex = 18;
            this.lblLogradouroCliente.Text = "Logradouro:";
            // 
            // lblNumeroLogradouroC
            // 
            this.lblNumeroLogradouroC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroLogradouroC.AutoSize = true;
            this.lblNumeroLogradouroC.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroLogradouroC.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLogradouroC.Location = new System.Drawing.Point(26, 385);
            this.lblNumeroLogradouroC.Name = "lblNumeroLogradouroC";
            this.lblNumeroLogradouroC.Size = new System.Drawing.Size(187, 30);
            this.lblNumeroLogradouroC.TabIndex = 19;
            this.lblNumeroLogradouroC.Text = "Número Logradouro:";
            // 
            // mskCepCliente
            // 
            this.mskCepCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCepCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCepCliente.Location = new System.Drawing.Point(161, 293);
            this.mskCepCliente.Mask = "00000-000";
            this.mskCepCliente.Name = "mskCepCliente";
            this.mskCepCliente.Size = new System.Drawing.Size(166, 33);
            this.mskCepCliente.TabIndex = 20;
            // 
            // frmAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 529);
            this.Controls.Add(this.mskCepCliente);
            this.Controls.Add(this.lblNumeroLogradouroC);
            this.Controls.Add(this.lblLogradouroCliente);
            this.Controls.Add(this.lblCepCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblCidadeCliente);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtNumeroLCliente);
            this.Controls.Add(this.cmbUF);
            this.Controls.Add(this.txtLogradouroCliente);
            this.Controls.Add(this.mskTelefoneCliente);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCliente;
        private System.Windows.Forms.TextBox txtLogradouroCliente;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.TextBox txtNumeroLCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidadeCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Label lblCepCliente;
        private System.Windows.Forms.Label lblLogradouroCliente;
        private System.Windows.Forms.Label lblNumeroLogradouroC;
        private System.Windows.Forms.MaskedTextBox mskCepCliente;
    }
}


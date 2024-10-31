namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFrmCadastrarVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFiltrarNomeCliente = new System.Windows.Forms.Button();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarVenda = new System.Windows.Forms.Button();
            this.btnAlterarVenda = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnQuantidade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnQuantidade);
            this.panel1.Controls.Add(this.btnFrmCadastrarVenda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnFiltrarNomeCliente);
            this.panel1.Controls.Add(this.txtPesquisarCliente);
            this.panel1.Controls.Add(this.btnExcluirVenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConsultarVenda);
            this.panel1.Controls.Add(this.btnAlterarVenda);
            this.panel1.Location = new System.Drawing.Point(-14, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 143);
            this.panel1.TabIndex = 16;
            // 
            // btnFrmCadastrarVenda
            // 
            this.btnFrmCadastrarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFrmCadastrarVenda.BackColor = System.Drawing.Color.Lavender;
            this.btnFrmCadastrarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFrmCadastrarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmCadastrarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFrmCadastrarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFrmCadastrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCadastrarVenda.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnFrmCadastrarVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFrmCadastrarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmCadastrarVenda.Image")));
            this.btnFrmCadastrarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmCadastrarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFrmCadastrarVenda.Location = new System.Drawing.Point(86, 24);
            this.btnFrmCadastrarVenda.Name = "btnFrmCadastrarVenda";
            this.btnFrmCadastrarVenda.Padding = new System.Windows.Forms.Padding(5);
            this.btnFrmCadastrarVenda.Size = new System.Drawing.Size(180, 45);
            this.btnFrmCadastrarVenda.TabIndex = 1;
            this.btnFrmCadastrarVenda.Text = "     Cadastrar  ";
            this.btnFrmCadastrarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFrmCadastrarVenda.UseVisualStyleBackColor = false;
            this.btnFrmCadastrarVenda.Click += new System.EventHandler(this.btnFrmCadastrarVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(900, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5);
            this.btnSair.Size = new System.Drawing.Size(168, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFiltrarNomeCliente
            // 
            this.btnFiltrarNomeCliente.BackColor = System.Drawing.Color.Lavender;
            this.btnFiltrarNomeCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarNomeCliente.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFiltrarNomeCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFiltrarNomeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarNomeCliente.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnFiltrarNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarNomeCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarNomeCliente.Image")));
            this.btnFiltrarNomeCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFiltrarNomeCliente.Location = new System.Drawing.Point(462, 82);
            this.btnFiltrarNomeCliente.Name = "btnFiltrarNomeCliente";
            this.btnFiltrarNomeCliente.Size = new System.Drawing.Size(279, 41);
            this.btnFiltrarNomeCliente.TabIndex = 9;
            this.btnFiltrarNomeCliente.Text = "Filtrar por Cliente";
            this.btnFiltrarNomeCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarNomeCliente.Click += new System.EventHandler(this.btnFiltrarNomeCliente_Click);
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.BackColor = System.Drawing.Color.Lavender;
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.txtPesquisarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPesquisarCliente.Location = new System.Drawing.Point(138, 84);
            this.txtPesquisarCliente.Multiline = true;
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(318, 35);
            this.txtPesquisarCliente.TabIndex = 11;
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirVenda.BackColor = System.Drawing.Color.Lavender;
            this.btnExcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirVenda.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnExcluirVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVenda.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnExcluirVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirVenda.Image")));
            this.btnExcluirVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirVenda.Location = new System.Drawing.Point(504, 24);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluirVenda.Size = new System.Drawing.Size(186, 45);
            this.btnExcluirVenda.TabIndex = 4;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = false;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar";
            // 
            // btnConsultarVenda
            // 
            this.btnConsultarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarVenda.BackColor = System.Drawing.Color.Lavender;
            this.btnConsultarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnConsultarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnConsultarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVenda.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnConsultarVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarVenda.Image")));
            this.btnConsultarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultarVenda.Location = new System.Drawing.Point(278, 24);
            this.btnConsultarVenda.Name = "btnConsultarVenda";
            this.btnConsultarVenda.Padding = new System.Windows.Forms.Padding(5);
            this.btnConsultarVenda.Size = new System.Drawing.Size(208, 45);
            this.btnConsultarVenda.TabIndex = 8;
            this.btnConsultarVenda.Text = "Consultar";
            this.btnConsultarVenda.UseVisualStyleBackColor = false;
            this.btnConsultarVenda.Click += new System.EventHandler(this.btnConsultarVenda_Click);
            // 
            // btnAlterarVenda
            // 
            this.btnAlterarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarVenda.BackColor = System.Drawing.Color.Lavender;
            this.btnAlterarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAlterarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnAlterarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarVenda.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnAlterarVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarVenda.Image")));
            this.btnAlterarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarVenda.Location = new System.Drawing.Point(701, 24);
            this.btnAlterarVenda.Name = "btnAlterarVenda";
            this.btnAlterarVenda.Padding = new System.Windows.Forms.Padding(5);
            this.btnAlterarVenda.Size = new System.Drawing.Size(188, 45);
            this.btnAlterarVenda.TabIndex = 7;
            this.btnAlterarVenda.Text = "Alterar";
            this.btnAlterarVenda.UseVisualStyleBackColor = false;
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowDrop = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenda.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVenda.Location = new System.Drawing.Point(124, 164);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVenda.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVenda.RowTemplate.Height = 24;
            this.dgvVenda.Size = new System.Drawing.Size(893, 471);
            this.dgvVenda.TabIndex = 19;
            // 
            // btnQuantidade
            // 
            this.btnQuantidade.BackColor = System.Drawing.Color.Lavender;
            this.btnQuantidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantidade.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnQuantidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantidade.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuantidade.Image = ((System.Drawing.Image)(resources.GetObject("btnQuantidade.Image")));
            this.btnQuantidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuantidade.Location = new System.Drawing.Point(767, 82);
            this.btnQuantidade.Name = "btnQuantidade";
            this.btnQuantidade.Size = new System.Drawing.Size(238, 41);
            this.btnQuantidade.TabIndex = 14;
            this.btnQuantidade.Text = "Quantidade de compras por Cliente";
            this.btnQuantidade.UseVisualStyleBackColor = false;
            this.btnQuantidade.Click += new System.EventHandler(this.btnQuantidade_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1115, 658);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFrmCadastrarVenda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFiltrarNomeCliente;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarVenda;
        private System.Windows.Forms.Button btnAlterarVenda;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnQuantidade;
    }
}
namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmPlantacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFrmCadastrarPlantacao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirPlantacao = new System.Windows.Forms.Button();
            this.btnConsultarPlantacao = new System.Windows.Forms.Button();
            this.btnAlterarPlantacao = new System.Windows.Forms.Button();
            this.dgvPlantacao = new System.Windows.Forms.DataGridView();
            this.btnFiltrarNomeInsumo = new System.Windows.Forms.Button();
            this.txtPesquisarNomeInsumo = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantacao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnFiltrarNomeInsumo);
            this.panel1.Controls.Add(this.txtPesquisarNomeInsumo);
            this.panel1.Controls.Add(this.lblPesquisar);
            this.panel1.Controls.Add(this.btnFrmCadastrarPlantacao);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnExcluirPlantacao);
            this.panel1.Controls.Add(this.btnConsultarPlantacao);
            this.panel1.Controls.Add(this.btnAlterarPlantacao);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 136);
            this.panel1.TabIndex = 16;
            // 
            // btnFrmCadastrarPlantacao
            // 
            this.btnFrmCadastrarPlantacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFrmCadastrarPlantacao.BackColor = System.Drawing.Color.Lavender;
            this.btnFrmCadastrarPlantacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFrmCadastrarPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmCadastrarPlantacao.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFrmCadastrarPlantacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFrmCadastrarPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCadastrarPlantacao.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnFrmCadastrarPlantacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFrmCadastrarPlantacao.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmCadastrarPlantacao.Image")));
            this.btnFrmCadastrarPlantacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmCadastrarPlantacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFrmCadastrarPlantacao.Location = new System.Drawing.Point(11, 25);
            this.btnFrmCadastrarPlantacao.Name = "btnFrmCadastrarPlantacao";
            this.btnFrmCadastrarPlantacao.Padding = new System.Windows.Forms.Padding(5);
            this.btnFrmCadastrarPlantacao.Size = new System.Drawing.Size(193, 45);
            this.btnFrmCadastrarPlantacao.TabIndex = 1;
            this.btnFrmCadastrarPlantacao.Text = "Cadastrar  ";
            this.btnFrmCadastrarPlantacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFrmCadastrarPlantacao.UseVisualStyleBackColor = false;
            this.btnFrmCadastrarPlantacao.Click += new System.EventHandler(this.btnFrmCadastrarPlantacao_Click);
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
            this.btnSair.Location = new System.Drawing.Point(839, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5);
            this.btnSair.Size = new System.Drawing.Size(168, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluirPlantacao
            // 
            this.btnExcluirPlantacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirPlantacao.BackColor = System.Drawing.Color.Lavender;
            this.btnExcluirPlantacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPlantacao.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnExcluirPlantacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnExcluirPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPlantacao.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnExcluirPlantacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirPlantacao.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPlantacao.Image")));
            this.btnExcluirPlantacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirPlantacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirPlantacao.Location = new System.Drawing.Point(443, 25);
            this.btnExcluirPlantacao.Name = "btnExcluirPlantacao";
            this.btnExcluirPlantacao.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluirPlantacao.Size = new System.Drawing.Size(186, 45);
            this.btnExcluirPlantacao.TabIndex = 4;
            this.btnExcluirPlantacao.Text = "Excluir";
            this.btnExcluirPlantacao.UseVisualStyleBackColor = false;
            this.btnExcluirPlantacao.Click += new System.EventHandler(this.btnExcluirPlantacao_Click);
            // 
            // btnConsultarPlantacao
            // 
            this.btnConsultarPlantacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarPlantacao.BackColor = System.Drawing.Color.Lavender;
            this.btnConsultarPlantacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPlantacao.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnConsultarPlantacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnConsultarPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPlantacao.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnConsultarPlantacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarPlantacao.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPlantacao.Image")));
            this.btnConsultarPlantacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPlantacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultarPlantacao.Location = new System.Drawing.Point(217, 25);
            this.btnConsultarPlantacao.Name = "btnConsultarPlantacao";
            this.btnConsultarPlantacao.Padding = new System.Windows.Forms.Padding(5);
            this.btnConsultarPlantacao.Size = new System.Drawing.Size(208, 45);
            this.btnConsultarPlantacao.TabIndex = 8;
            this.btnConsultarPlantacao.Text = "Consultar";
            this.btnConsultarPlantacao.UseVisualStyleBackColor = false;
            this.btnConsultarPlantacao.Click += new System.EventHandler(this.btnConsultarPlantacao_Click);
            // 
            // btnAlterarPlantacao
            // 
            this.btnAlterarPlantacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarPlantacao.BackColor = System.Drawing.Color.Lavender;
            this.btnAlterarPlantacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPlantacao.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAlterarPlantacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnAlterarPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPlantacao.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.btnAlterarPlantacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterarPlantacao.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarPlantacao.Image")));
            this.btnAlterarPlantacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPlantacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarPlantacao.Location = new System.Drawing.Point(640, 25);
            this.btnAlterarPlantacao.Name = "btnAlterarPlantacao";
            this.btnAlterarPlantacao.Padding = new System.Windows.Forms.Padding(5);
            this.btnAlterarPlantacao.Size = new System.Drawing.Size(188, 45);
            this.btnAlterarPlantacao.TabIndex = 7;
            this.btnAlterarPlantacao.Text = "Alterar";
            this.btnAlterarPlantacao.UseVisualStyleBackColor = false;
            this.btnAlterarPlantacao.Click += new System.EventHandler(this.btnAlterarPlantacao_Click);
            // 
            // dgvPlantacao
            // 
            this.dgvPlantacao.AllowDrop = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvPlantacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlantacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlantacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlantacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlantacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlantacao.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlantacao.Location = new System.Drawing.Point(106, 151);
            this.dgvPlantacao.Name = "dgvPlantacao";
            this.dgvPlantacao.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlantacao.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlantacao.RowTemplate.Height = 24;
            this.dgvPlantacao.Size = new System.Drawing.Size(822, 478);
            this.dgvPlantacao.TabIndex = 17;
            // 
            // btnFiltrarNomeInsumo
            // 
            this.btnFiltrarNomeInsumo.BackColor = System.Drawing.Color.Lavender;
            this.btnFiltrarNomeInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarNomeInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFiltrarNomeInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFiltrarNomeInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarNomeInsumo.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarNomeInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarNomeInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarNomeInsumo.Image")));
            this.btnFiltrarNomeInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarNomeInsumo.Location = new System.Drawing.Point(448, 80);
            this.btnFiltrarNomeInsumo.Name = "btnFiltrarNomeInsumo";
            this.btnFiltrarNomeInsumo.Size = new System.Drawing.Size(279, 41);
            this.btnFiltrarNomeInsumo.TabIndex = 16;
            this.btnFiltrarNomeInsumo.Text = "Filtrar por Insumo";
            this.btnFiltrarNomeInsumo.UseVisualStyleBackColor = false;
            this.btnFiltrarNomeInsumo.Click += new System.EventHandler(this.btnFiltrarNomeInsumo_Click);
            // 
            // txtPesquisarNomeInsumo
            // 
            this.txtPesquisarNomeInsumo.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarNomeInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPesquisarNomeInsumo.Location = new System.Drawing.Point(124, 82);
            this.txtPesquisarNomeInsumo.Name = "txtPesquisarNomeInsumo";
            this.txtPesquisarNomeInsumo.Size = new System.Drawing.Size(318, 34);
            this.txtPesquisarNomeInsumo.TabIndex = 14;
            this.txtPesquisarNomeInsumo.TextChanged += new System.EventHandler(this.txtPesquisarNomeInsumo_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(18, 84);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(100, 31);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "Pesquisar";
            this.lblPesquisar.Click += new System.EventHandler(this.lblPesquisar_Click);
            // 
            // frmPlantacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1020, 658);
            this.Controls.Add(this.dgvPlantacao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlantacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFrmCadastrarPlantacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirPlantacao;
        private System.Windows.Forms.Button btnConsultarPlantacao;
        private System.Windows.Forms.Button btnAlterarPlantacao;
        private System.Windows.Forms.DataGridView dgvPlantacao;
        private System.Windows.Forms.Button btnFiltrarNomeInsumo;
        private System.Windows.Forms.TextBox txtPesquisarNomeInsumo;
        private System.Windows.Forms.Label lblPesquisar;
    }
}
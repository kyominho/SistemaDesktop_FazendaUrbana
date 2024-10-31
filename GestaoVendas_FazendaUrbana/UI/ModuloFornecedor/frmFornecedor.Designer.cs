namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFrmAddFornecedor = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.btnAlterarFornecedor = new System.Windows.Forms.Button();
            this.txtPesquisarFornecedor = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnFiltrarNomeFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmAddFornecedor
            // 
            this.btnFrmAddFornecedor.AutoSize = true;
            this.btnFrmAddFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.btnFrmAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmAddFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFrmAddFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFrmAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmAddFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmAddFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFrmAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmAddFornecedor.Image")));
            this.btnFrmAddFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmAddFornecedor.Location = new System.Drawing.Point(14, 26);
            this.btnFrmAddFornecedor.Name = "btnFrmAddFornecedor";
            this.btnFrmAddFornecedor.Size = new System.Drawing.Size(182, 45);
            this.btnFrmAddFornecedor.TabIndex = 0;
            this.btnFrmAddFornecedor.Text = "     Cadastrar";
            this.btnFrmAddFornecedor.UseVisualStyleBackColor = false;
            this.btnFrmAddFornecedor.Click += new System.EventHandler(this.btnFrmAddFornecedor_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(803, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 45);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvFornecedor
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFornecedor.Location = new System.Drawing.Point(94, 186);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.RowHeadersWidth = 51;
            this.dgvFornecedor.RowTemplate.Height = 24;
            this.dgvFornecedor.Size = new System.Drawing.Size(796, 445);
            this.dgvFornecedor.TabIndex = 2;
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.btnConsultarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnConsultarFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFornecedor.Image")));
            this.btnConsultarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(213, 26);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(180, 45);
            this.btnConsultarFornecedor.TabIndex = 3;
            this.btnConsultarFornecedor.Text = "      Consultar";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // btnAlterarFornecedor
            // 
            this.btnAlterarFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.btnAlterarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnAlterarFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnAlterarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFornecedor.Image")));
            this.btnAlterarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFornecedor.Location = new System.Drawing.Point(410, 26);
            this.btnAlterarFornecedor.Name = "btnAlterarFornecedor";
            this.btnAlterarFornecedor.Size = new System.Drawing.Size(180, 45);
            this.btnAlterarFornecedor.TabIndex = 4;
            this.btnAlterarFornecedor.Text = "Alterar";
            this.btnAlterarFornecedor.UseVisualStyleBackColor = false;
            this.btnAlterarFornecedor.Click += new System.EventHandler(this.btnAlterarFornecedor_Click);
            // 
            // txtPesquisarFornecedor
            // 
            this.txtPesquisarFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPesquisarFornecedor.Location = new System.Drawing.Point(120, 82);
            this.txtPesquisarFornecedor.Name = "txtPesquisarFornecedor";
            this.txtPesquisarFornecedor.Size = new System.Drawing.Size(318, 34);
            this.txtPesquisarFornecedor.TabIndex = 5;
           
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(14, 84);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(100, 31);
            this.lblPesquisar.TabIndex = 6;
            this.lblPesquisar.Text = "Pesquisar";
            this.lblPesquisar.Click += new System.EventHandler(this.lblPesquisar_Click);
            // 
            // btnFiltrarNomeFornecedor
            // 
            this.btnFiltrarNomeFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.btnFiltrarNomeFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarNomeFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnFiltrarNomeFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnFiltrarNomeFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarNomeFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarNomeFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarNomeFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarNomeFornecedor.Image")));
            this.btnFiltrarNomeFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarNomeFornecedor.Location = new System.Drawing.Point(444, 80);
            this.btnFiltrarNomeFornecedor.Name = "btnFiltrarNomeFornecedor";
            this.btnFiltrarNomeFornecedor.Size = new System.Drawing.Size(279, 41);
            this.btnFiltrarNomeFornecedor.TabIndex = 7;
            this.btnFiltrarNomeFornecedor.Text = "Filtrar por Nome";
            this.btnFiltrarNomeFornecedor.UseVisualStyleBackColor = false;
            this.btnFiltrarNomeFornecedor.Click += new System.EventHandler(this.btnFiltrarNomeFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.BackColor = System.Drawing.Color.Lavender;
            this.btnExcluirFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnExcluirFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnExcluirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFornecedor.Image")));
            this.btnExcluirFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(607, 26);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(180, 45);
            this.btnExcluirFornecedor.TabIndex = 8;
            this.btnExcluirFornecedor.Text = "Excluir";
            this.btnExcluirFornecedor.UseVisualStyleBackColor = false;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnConsultarFornecedor);
            this.panel1.Controls.Add(this.btnFiltrarNomeFornecedor);
            this.panel1.Controls.Add(this.btnExcluirFornecedor);
            this.panel1.Controls.Add(this.txtPesquisarFornecedor);
            this.panel1.Controls.Add(this.lblPesquisar);
            this.panel1.Controls.Add(this.btnAlterarFornecedor);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnFrmAddFornecedor);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 159);
            this.panel1.TabIndex = 15;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(993, 682);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmAddFornecedor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btnAlterarFornecedor;
        private System.Windows.Forms.TextBox txtPesquisarFornecedor;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnFiltrarNomeFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.Panel panel1;
    }
}
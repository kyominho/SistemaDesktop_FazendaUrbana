namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmAddProduto
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
            this.txtEstoqueProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.dtpDataValidadeProduto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.SuspendLayout();
            // 
            // txtEstoqueProduto
            // 
            this.txtEstoqueProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueProduto.Location = new System.Drawing.Point(144, 147);
            this.txtEstoqueProduto.Name = "txtEstoqueProduto";
            this.txtEstoqueProduto.Size = new System.Drawing.Size(78, 34);
            this.txtEstoqueProduto.TabIndex = 28;
            this.txtEstoqueProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueProduto_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Estoque:";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(140, 283);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(145, 37);
            this.btnCadastrarProduto.TabIndex = 26;
            this.btnCadastrarProduto.Text = "Gravar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoProduto.Location = new System.Drawing.Point(140, 93);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(132, 34);
            this.txtPrecoProduto.TabIndex = 25;
            this.txtPrecoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoProduto_KeyPress);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.Location = new System.Drawing.Point(140, 39);
            this.txtNomeProduto.MaxLength = 60;
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(247, 34);
            this.txtNomeProduto.TabIndex = 24;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            // 
            // dtpDataValidadeProduto
            // 
            this.dtpDataValidadeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataValidadeProduto.Checked = false;
            this.dtpDataValidadeProduto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpDataValidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidadeProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidadeProduto.Location = new System.Drawing.Point(228, 201);
            this.dtpDataValidadeProduto.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.dtpDataValidadeProduto.MinDate = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            this.dtpDataValidadeProduto.Name = "dtpDataValidadeProduto";
            this.dtpDataValidadeProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataValidadeProduto.Size = new System.Drawing.Size(141, 28);
            this.dtpDataValidadeProduto.TabIndex = 23;
            this.dtpDataValidadeProduto.Value = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data de Validade:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // frmAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 348);
            this.Controls.Add(this.txtEstoqueProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.dtpDataValidadeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstoqueProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DateTimePicker dtpDataValidadeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}
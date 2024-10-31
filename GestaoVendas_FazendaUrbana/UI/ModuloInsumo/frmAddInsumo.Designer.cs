namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmAddInsumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataValidadeInsumo = new System.Windows.Forms.DateTimePicker();
            this.txtNomeInsumo = new System.Windows.Forms.TextBox();
            this.txtPrecoInsumo = new System.Windows.Forms.TextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoqueInsumo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Validade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDataValidadeInsumo
            // 
            this.txtDataValidadeInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataValidadeInsumo.Checked = false;
            this.txtDataValidadeInsumo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtDataValidadeInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataValidadeInsumo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataValidadeInsumo.Location = new System.Drawing.Point(213, 147);
            this.txtDataValidadeInsumo.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.txtDataValidadeInsumo.MinDate = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            this.txtDataValidadeInsumo.Name = "txtDataValidadeInsumo";
            this.txtDataValidadeInsumo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataValidadeInsumo.Size = new System.Drawing.Size(141, 28);
            this.txtDataValidadeInsumo.TabIndex = 14;
            this.txtDataValidadeInsumo.Value = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            this.txtDataValidadeInsumo.ValueChanged += new System.EventHandler(this.txtDataValidadeInsumo_ValueChanged);
            this.txtDataValidadeInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataValidadeInsumo_KeyPress);
            // 
            // txtNomeInsumo
            // 
            this.txtNomeInsumo.Location = new System.Drawing.Point(112, 45);
            this.txtNomeInsumo.Name = "txtNomeInsumo";
            this.txtNomeInsumo.Size = new System.Drawing.Size(242, 34);
            this.txtNomeInsumo.TabIndex = 15;
            this.txtNomeInsumo.TextChanged += new System.EventHandler(this.txtNomeInsumo_TextChanged);
            this.txtNomeInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeInsumo_KeyPress);
            // 
            // txtPrecoInsumo
            // 
            this.txtPrecoInsumo.Location = new System.Drawing.Point(108, 194);
            this.txtPrecoInsumo.Name = "txtPrecoInsumo";
            this.txtPrecoInsumo.Size = new System.Drawing.Size(132, 34);
            this.txtPrecoInsumo.TabIndex = 16;
            this.txtPrecoInsumo.TextChanged += new System.EventHandler(this.txtPrecoInsumo_TextChanged);
            this.txtPrecoInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoInsumo_KeyPress);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(144, 279);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(145, 37);
            this.btnCadastrarProduto.TabIndex = 17;
            this.btnCadastrarProduto.Text = "Gravar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarInsumo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estoque:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEstoqueInsumo
            // 
            this.txtEstoqueInsumo.Location = new System.Drawing.Point(129, 94);
            this.txtEstoqueInsumo.Name = "txtEstoqueInsumo";
            this.txtEstoqueInsumo.Size = new System.Drawing.Size(78, 34);
            this.txtEstoqueInsumo.TabIndex = 19;
            this.txtEstoqueInsumo.TextChanged += new System.EventHandler(this.txtEstoqueInsumo_TextChanged);
            this.txtEstoqueInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueInsumo_KeyPress);
            // 
            // frmAddInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 348);
            this.Controls.Add(this.txtEstoqueInsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtPrecoInsumo);
            this.Controls.Add(this.txtNomeInsumo);
            this.Controls.Add(this.txtDataValidadeInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAddInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddInsumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataValidadeInsumo;
        private System.Windows.Forms.TextBox txtNomeInsumo;
        private System.Windows.Forms.TextBox txtPrecoInsumo;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstoqueInsumo;
    }
}
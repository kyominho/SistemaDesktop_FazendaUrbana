namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmAddColheita
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHorarioColheita = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrarColheita = new System.Windows.Forms.Button();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeColhida = new System.Windows.Forms.TextBox();
            this.dtpDataColheita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Horário:";
            // 
            // dtpHorarioColheita
            // 
            this.dtpHorarioColheita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioColheita.Location = new System.Drawing.Point(160, 92);
            this.dtpHorarioColheita.Name = "dtpHorarioColheita";
            this.dtpHorarioColheita.ShowUpDown = true;
            this.dtpHorarioColheita.Size = new System.Drawing.Size(108, 34);
            this.dtpHorarioColheita.TabIndex = 16;
            // 
            // btnCadastrarColheita
            // 
            this.btnCadastrarColheita.Location = new System.Drawing.Point(160, 311);
            this.btnCadastrarColheita.Name = "btnCadastrarColheita";
            this.btnCadastrarColheita.Size = new System.Drawing.Size(149, 43);
            this.btnCadastrarColheita.TabIndex = 15;
            this.btnCadastrarColheita.Text = "Gravar";
            this.btnCadastrarColheita.UseVisualStyleBackColor = true;
            this.btnCadastrarColheita.Click += new System.EventHandler(this.btnCadastrarColheita_Click);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(233, 213);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(170, 39);
            this.cmbProdutos.TabIndex = 14;
            // 
            // txtQuantidadeColhida
            // 
            this.txtQuantidadeColhida.Location = new System.Drawing.Point(264, 152);
            this.txtQuantidadeColhida.Name = "txtQuantidadeColhida";
            this.txtQuantidadeColhida.Size = new System.Drawing.Size(100, 34);
            this.txtQuantidadeColhida.TabIndex = 13;
            this.txtQuantidadeColhida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeColhida_KeyPress);
            // 
            // dtpDataColheita
            // 
            this.dtpDataColheita.Checked = false;
            this.dtpDataColheita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataColheita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataColheita.Location = new System.Drawing.Point(138, 42);
            this.dtpDataColheita.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtpDataColheita.MinDate = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            this.dtpDataColheita.Name = "dtpDataColheita";
            this.dtpDataColheita.Size = new System.Drawing.Size(140, 28);
            this.dtpDataColheita.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produto Colhido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade Colhida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data:";
            // 
            // frmAddColheita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHorarioColheita);
            this.Controls.Add(this.btnCadastrarColheita);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.txtQuantidadeColhida);
            this.Controls.Add(this.dtpDataColheita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAddColheita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddColheita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHorarioColheita;
        private System.Windows.Forms.Button btnCadastrarColheita;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.TextBox txtQuantidadeColhida;
        private System.Windows.Forms.DateTimePicker dtpDataColheita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
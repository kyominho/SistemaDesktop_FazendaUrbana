namespace GestaoVendas_FazendaUrbana.UI
{
    partial class frmAddPlantacao
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
            this.dtpDataPlantacao = new System.Windows.Forms.DateTimePicker();
            this.txtQuantidadePlantada = new System.Windows.Forms.TextBox();
            this.cmbInsumos = new System.Windows.Forms.ComboBox();
            this.btnCadastrarPlantacao = new System.Windows.Forms.Button();
            this.dtpHorarioPlantacao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Plantada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insumo Plantado:";
            // 
            // dtpDataPlantacao
            // 
            this.dtpDataPlantacao.Checked = false;
            this.dtpDataPlantacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPlantacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPlantacao.Location = new System.Drawing.Point(98, 44);
            this.dtpDataPlantacao.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtpDataPlantacao.MinDate = new System.DateTime(2024, 10, 25, 23, 59, 59, 0);
            this.dtpDataPlantacao.Name = "dtpDataPlantacao";
            this.dtpDataPlantacao.Size = new System.Drawing.Size(140, 28);
            this.dtpDataPlantacao.TabIndex = 3;
            // 
            // txtQuantidadePlantada
            // 
            this.txtQuantidadePlantada.Location = new System.Drawing.Point(248, 154);
            this.txtQuantidadePlantada.Name = "txtQuantidadePlantada";
            this.txtQuantidadePlantada.Size = new System.Drawing.Size(100, 34);
            this.txtQuantidadePlantada.TabIndex = 4;
            this.txtQuantidadePlantada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadePlantada_KeyPress);
            // 
            // cmbInsumos
            // 
            this.cmbInsumos.FormattingEnabled = true;
            this.cmbInsumos.Location = new System.Drawing.Point(208, 215);
            this.cmbInsumos.Name = "cmbInsumos";
            this.cmbInsumos.Size = new System.Drawing.Size(170, 39);
            this.cmbInsumos.TabIndex = 5;
            // 
            // btnCadastrarPlantacao
            // 
            this.btnCadastrarPlantacao.Location = new System.Drawing.Point(162, 308);
            this.btnCadastrarPlantacao.Name = "btnCadastrarPlantacao";
            this.btnCadastrarPlantacao.Size = new System.Drawing.Size(149, 43);
            this.btnCadastrarPlantacao.TabIndex = 6;
            this.btnCadastrarPlantacao.Text = "Gravar";
            this.btnCadastrarPlantacao.UseVisualStyleBackColor = true;
            this.btnCadastrarPlantacao.Click += new System.EventHandler(this.btnCadastrarPlantacao_Click);
            // 
            // dtpHorarioPlantacao
            // 
            this.dtpHorarioPlantacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioPlantacao.Location = new System.Drawing.Point(120, 94);
            this.dtpHorarioPlantacao.Name = "dtpHorarioPlantacao";
            this.dtpHorarioPlantacao.ShowUpDown = true;
            this.dtpHorarioPlantacao.Size = new System.Drawing.Size(108, 34);
            this.dtpHorarioPlantacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horário:";
            // 
            // frmAddPlantacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHorarioPlantacao);
            this.Controls.Add(this.btnCadastrarPlantacao);
            this.Controls.Add(this.cmbInsumos);
            this.Controls.Add(this.txtQuantidadePlantada);
            this.Controls.Add(this.dtpDataPlantacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAddPlantacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddPlantacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataPlantacao;
        private System.Windows.Forms.TextBox txtQuantidadePlantada;
        private System.Windows.Forms.ComboBox cmbInsumos;
        private System.Windows.Forms.Button btnCadastrarPlantacao;
        private System.Windows.Forms.DateTimePicker dtpHorarioPlantacao;
        private System.Windows.Forms.Label label4;
    }
}
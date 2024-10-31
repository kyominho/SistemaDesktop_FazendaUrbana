namespace GestaoVendas_FazendaUrbana.UI.ModuloCliente
{
    partial class frmAddClienteFisico
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
            this.components = new System.ComponentModel.Container();
            this.lblNomeClienteF = new System.Windows.Forms.Label();
            this.cmbNomeClienteF = new System.Windows.Forms.ComboBox();
            this.lblCpfClienteF = new System.Windows.Forms.Label();
            this.mskCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarClienteF = new System.Windows.Forms.Button();
            this.clienteFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeClienteF
            // 
            this.lblNomeClienteF.AutoSize = true;
            this.lblNomeClienteF.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClienteF.Location = new System.Drawing.Point(23, 114);
            this.lblNomeClienteF.Name = "lblNomeClienteF";
            this.lblNomeClienteF.Size = new System.Drawing.Size(81, 31);
            this.lblNomeClienteF.TabIndex = 0;
            this.lblNomeClienteF.Text = "Cliente:";
            // 
            // cmbNomeClienteF
            // 
            this.cmbNomeClienteF.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeClienteF.FormattingEnabled = true;
            this.cmbNomeClienteF.Location = new System.Drawing.Point(110, 111);
            this.cmbNomeClienteF.Name = "cmbNomeClienteF";
            this.cmbNomeClienteF.Size = new System.Drawing.Size(225, 39);
            this.cmbNomeClienteF.TabIndex = 1;
            // 
            // lblCpfClienteF
            // 
            this.lblCpfClienteF.AutoSize = true;
            this.lblCpfClienteF.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfClienteF.Location = new System.Drawing.Point(23, 44);
            this.lblCpfClienteF.Name = "lblCpfClienteF";
            this.lblCpfClienteF.Size = new System.Drawing.Size(51, 31);
            this.lblCpfClienteF.TabIndex = 2;
            this.lblCpfClienteF.Text = "CPF:";
            // 
            // mskCpfCliente
            // 
            this.mskCpfCliente.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpfCliente.Location = new System.Drawing.Point(102, 41);
            this.mskCpfCliente.Mask = "000,000,000-00";
            this.mskCpfCliente.Name = "mskCpfCliente";
            this.mskCpfCliente.Size = new System.Drawing.Size(233, 34);
            this.mskCpfCliente.TabIndex = 3;
            // 
            // btnCadastrarClienteF
            // 
            this.btnCadastrarClienteF.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClienteF.Location = new System.Drawing.Point(102, 218);
            this.btnCadastrarClienteF.Name = "btnCadastrarClienteF";
            this.btnCadastrarClienteF.Size = new System.Drawing.Size(145, 37);
            this.btnCadastrarClienteF.TabIndex = 4;
            this.btnCadastrarClienteF.Text = "Gravar";
            this.btnCadastrarClienteF.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteF.Click += new System.EventHandler(this.btnCadastrarClienteF_Click);
            // 
            // clienteFisicoBindingSource
            // 
            this.clienteFisicoBindingSource.DataMember = "ClienteFisico";
            // 
            // frmAddClienteFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 300);
            this.Controls.Add(this.btnCadastrarClienteF);
            this.Controls.Add(this.mskCpfCliente);
            this.Controls.Add(this.lblCpfClienteF);
            this.Controls.Add(this.cmbNomeClienteF);
            this.Controls.Add(this.lblNomeClienteF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddClienteFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddClienteFisico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteFisicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeClienteF;
        private System.Windows.Forms.ComboBox cmbNomeClienteF;
        private System.Windows.Forms.Label lblCpfClienteF;
        private System.Windows.Forms.MaskedTextBox mskCpfCliente;
        private System.Windows.Forms.Button btnCadastrarClienteF;
        private System.Windows.Forms.BindingSource clienteFisicoBindingSource;

    }
}
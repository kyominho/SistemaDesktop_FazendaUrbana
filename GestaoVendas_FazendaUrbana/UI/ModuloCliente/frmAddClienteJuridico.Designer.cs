namespace GestaoVendas_FazendaUrbana.UI.ModuloCliente
{
    partial class frmAddClienteJuridico
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
            this.mskCNPJClienteJuridico = new System.Windows.Forms.MaskedTextBox();
            this.cmbNomeClienteJ = new System.Windows.Forms.ComboBox();
            this.lblCNPJClienteJ = new System.Windows.Forms.Label();
            this.lblNomeClienteJ = new System.Windows.Forms.Label();
            this.btnCadastrarClienteJ = new System.Windows.Forms.Button();
            this.txtRazaoSocialCliente = new System.Windows.Forms.TextBox();
            this.lblRazaoSocialFornecedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskCNPJClienteJuridico
            // 
            this.mskCNPJClienteJuridico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCNPJClienteJuridico.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCNPJClienteJuridico.Location = new System.Drawing.Point(110, 35);
            this.mskCNPJClienteJuridico.Mask = "00,000,000/0000-00";
            this.mskCNPJClienteJuridico.Name = "mskCNPJClienteJuridico";
            this.mskCNPJClienteJuridico.Size = new System.Drawing.Size(225, 34);
            this.mskCNPJClienteJuridico.TabIndex = 16;
            this.mskCNPJClienteJuridico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCNPJClienteJuridico_KeyPress);
            // 
            // cmbNomeClienteJ
            // 
            this.cmbNomeClienteJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNomeClienteJ.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeClienteJ.FormattingEnabled = true;
            this.cmbNomeClienteJ.Location = new System.Drawing.Point(140, 152);
            this.cmbNomeClienteJ.Name = "cmbNomeClienteJ";
            this.cmbNomeClienteJ.Size = new System.Drawing.Size(241, 39);
            this.cmbNomeClienteJ.TabIndex = 17;
            // 
            // lblCNPJClienteJ
            // 
            this.lblCNPJClienteJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCNPJClienteJ.AutoSize = true;
            this.lblCNPJClienteJ.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJClienteJ.Location = new System.Drawing.Point(12, 35);
            this.lblCNPJClienteJ.Name = "lblCNPJClienteJ";
            this.lblCNPJClienteJ.Size = new System.Drawing.Size(65, 31);
            this.lblCNPJClienteJ.TabIndex = 19;
            this.lblCNPJClienteJ.Text = "CNPJ:";
            // 
            // lblNomeClienteJ
            // 
            this.lblNomeClienteJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeClienteJ.AutoSize = true;
            this.lblNomeClienteJ.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClienteJ.Location = new System.Drawing.Point(12, 155);
            this.lblNomeClienteJ.Name = "lblNomeClienteJ";
            this.lblNomeClienteJ.Size = new System.Drawing.Size(81, 31);
            this.lblNomeClienteJ.TabIndex = 18;
            this.lblNomeClienteJ.Text = "Cliente:";
            // 
            // btnCadastrarClienteJ
            // 
            this.btnCadastrarClienteJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarClienteJ.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClienteJ.Location = new System.Drawing.Point(140, 238);
            this.btnCadastrarClienteJ.Name = "btnCadastrarClienteJ";
            this.btnCadastrarClienteJ.Size = new System.Drawing.Size(158, 37);
            this.btnCadastrarClienteJ.TabIndex = 20;
            this.btnCadastrarClienteJ.Text = "Gravar";
            this.btnCadastrarClienteJ.UseVisualStyleBackColor = true;
            this.btnCadastrarClienteJ.Click += new System.EventHandler(this.btnCadastrarClienteJ_Click);
            // 
            // txtRazaoSocialCliente
            // 
            this.txtRazaoSocialCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocialCliente.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocialCliente.Location = new System.Drawing.Point(140, 91);
            this.txtRazaoSocialCliente.Name = "txtRazaoSocialCliente";
            this.txtRazaoSocialCliente.Size = new System.Drawing.Size(254, 33);
            this.txtRazaoSocialCliente.TabIndex = 22;
            this.txtRazaoSocialCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocialCliente_KeyPress);
            // 
            // lblRazaoSocialFornecedor
            // 
            this.lblRazaoSocialFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRazaoSocialFornecedor.AutoSize = true;
            this.lblRazaoSocialFornecedor.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocialFornecedor.Location = new System.Drawing.Point(11, 94);
            this.lblRazaoSocialFornecedor.Name = "lblRazaoSocialFornecedor";
            this.lblRazaoSocialFornecedor.Size = new System.Drawing.Size(123, 30);
            this.lblRazaoSocialFornecedor.TabIndex = 21;
            this.lblRazaoSocialFornecedor.Text = "Razão Social:";
            // 
            // frmAddClienteJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 300);
            this.Controls.Add(this.txtRazaoSocialCliente);
            this.Controls.Add(this.lblRazaoSocialFornecedor);
            this.Controls.Add(this.btnCadastrarClienteJ);
            this.Controls.Add(this.lblCNPJClienteJ);
            this.Controls.Add(this.lblNomeClienteJ);
            this.Controls.Add(this.cmbNomeClienteJ);
            this.Controls.Add(this.mskCNPJClienteJuridico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddClienteJuridico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddClienteJuridico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCNPJClienteJuridico;
        private System.Windows.Forms.ComboBox cmbNomeClienteJ;
        private System.Windows.Forms.Label lblCNPJClienteJ;
        private System.Windows.Forms.Label lblNomeClienteJ;
        private System.Windows.Forms.Button btnCadastrarClienteJ;
        private System.Windows.Forms.TextBox txtRazaoSocialCliente;
        private System.Windows.Forms.Label lblRazaoSocialFornecedor;
    }
}
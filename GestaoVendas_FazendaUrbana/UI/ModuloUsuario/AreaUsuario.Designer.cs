namespace GestaoVendas_FazendaUrbana.UI
{
    partial class AreaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaUsuario));
            this.lblLogado = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnAcoes = new System.Windows.Forms.Panel();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnInsumo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClienteJuridico = new System.Windows.Forms.Button();
            this.btnClienteFisico = new System.Windows.Forms.Button();
            this.btnPlantacao = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnColheita = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.lblDataHorarioAU = new System.Windows.Forms.Label();
            this.tDataHoraAU = new System.Windows.Forms.Timer(this.components);
            this.pnAcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogado
            // 
            this.lblLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogado.AutoSize = true;
            this.lblLogado.Cursor = System.Windows.Forms.Cursors.No;
            this.lblLogado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogado.Location = new System.Drawing.Point(23, 713);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(100, 36);
            this.lblLogado.TabIndex = 0;
            this.lblLogado.Text = "Usuário: ";
            this.lblLogado.Click += new System.EventHandler(this.lblLogado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCliente.BackColor = System.Drawing.Color.Lavender;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.Location = new System.Drawing.Point(12, 13);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(256, 517);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(1172, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(145, 42);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // pnAcoes
            // 
            this.pnAcoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnAcoes.BackColor = System.Drawing.Color.Azure;
            this.pnAcoes.Controls.Add(this.btnProduto);
            this.pnAcoes.Controls.Add(this.btnInsumo);
            this.pnAcoes.Controls.Add(this.panel1);
            this.pnAcoes.Controls.Add(this.btnPlantacao);
            this.pnAcoes.Controls.Add(this.btnEntrega);
            this.pnAcoes.Controls.Add(this.btnColheita);
            this.pnAcoes.Controls.Add(this.btnVenda);
            this.pnAcoes.Controls.Add(this.btnUsuario);
            this.pnAcoes.Controls.Add(this.btnFornecedor);
            this.pnAcoes.Controls.Add(this.btnCompra);
            this.pnAcoes.Location = new System.Drawing.Point(126, 119);
            this.pnAcoes.Name = "pnAcoes";
            this.pnAcoes.Size = new System.Drawing.Size(1117, 542);
            this.pnAcoes.TabIndex = 4;
            // 
            // btnProduto
            // 
            this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduto.BackColor = System.Drawing.Color.Azure;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(687, 185);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(190, 166);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "PRODUTO";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnInsumo
            // 
            this.btnInsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsumo.BackColor = System.Drawing.Color.Azure;
            this.btnInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumo.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnInsumo.Image")));
            this.btnInsumo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsumo.Location = new System.Drawing.Point(899, 357);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Size = new System.Drawing.Size(190, 166);
            this.btnInsumo.TabIndex = 5;
            this.btnInsumo.Text = "INSUMO";
            this.btnInsumo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsumo.UseVisualStyleBackColor = false;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClienteJuridico);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnClienteFisico);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 542);
            this.panel1.TabIndex = 0;
            // 
            // btnClienteJuridico
            // 
            this.btnClienteJuridico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClienteJuridico.BackColor = System.Drawing.Color.Lavender;
            this.btnClienteJuridico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteJuridico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClienteJuridico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClienteJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteJuridico.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteJuridico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClienteJuridico.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteJuridico.Image")));
            this.btnClienteJuridico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteJuridico.Location = new System.Drawing.Point(290, 274);
            this.btnClienteJuridico.Name = "btnClienteJuridico";
            this.btnClienteJuridico.Size = new System.Drawing.Size(160, 226);
            this.btnClienteJuridico.TabIndex = 16;
            this.btnClienteJuridico.Text = "CLIENTE JURIDICO";
            this.btnClienteJuridico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteJuridico.UseVisualStyleBackColor = false;
            this.btnClienteJuridico.Click += new System.EventHandler(this.btnClienteJuridico_Click);
            // 
            // btnClienteFisico
            // 
            this.btnClienteFisico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClienteFisico.BackColor = System.Drawing.Color.Lavender;
            this.btnClienteFisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteFisico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClienteFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClienteFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteFisico.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteFisico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClienteFisico.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteFisico.Image")));
            this.btnClienteFisico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteFisico.Location = new System.Drawing.Point(290, 26);
            this.btnClienteFisico.Name = "btnClienteFisico";
            this.btnClienteFisico.Size = new System.Drawing.Size(160, 221);
            this.btnClienteFisico.TabIndex = 15;
            this.btnClienteFisico.Text = "CLIENTE FISICO";
            this.btnClienteFisico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteFisico.UseVisualStyleBackColor = false;
            this.btnClienteFisico.Click += new System.EventHandler(this.btnClienteFisico_Click);
            // 
            // btnPlantacao
            // 
            this.btnPlantacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlantacao.BackColor = System.Drawing.Color.Azure;
            this.btnPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlantacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlantacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantacao.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlantacao.Image = ((System.Drawing.Image)(resources.GetObject("btnPlantacao.Image")));
            this.btnPlantacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlantacao.Location = new System.Drawing.Point(899, 185);
            this.btnPlantacao.Name = "btnPlantacao";
            this.btnPlantacao.Size = new System.Drawing.Size(190, 166);
            this.btnPlantacao.TabIndex = 10;
            this.btnPlantacao.Text = "PLANTACAO";
            this.btnPlantacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlantacao.UseVisualStyleBackColor = false;
            this.btnPlantacao.Click += new System.EventHandler(this.btnPlantacao_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrega.BackColor = System.Drawing.Color.Azure;
            this.btnEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrega.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrega.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrega.Image")));
            this.btnEntrega.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntrega.Location = new System.Drawing.Point(687, 357);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(190, 166);
            this.btnEntrega.TabIndex = 13;
            this.btnEntrega.Text = "ENTREGA";
            this.btnEntrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntrega.UseVisualStyleBackColor = false;
            // 
            // btnColheita
            // 
            this.btnColheita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColheita.BackColor = System.Drawing.Color.Azure;
            this.btnColheita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColheita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnColheita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnColheita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColheita.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColheita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColheita.Image = ((System.Drawing.Image)(resources.GetObject("btnColheita.Image")));
            this.btnColheita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColheita.Location = new System.Drawing.Point(481, 357);
            this.btnColheita.Name = "btnColheita";
            this.btnColheita.Size = new System.Drawing.Size(190, 166);
            this.btnColheita.TabIndex = 14;
            this.btnColheita.Text = "COLHEITA";
            this.btnColheita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColheita.UseVisualStyleBackColor = false;
            this.btnColheita.Click += new System.EventHandler(this.btnColheita_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVenda.BackColor = System.Drawing.Color.Azure;
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenda.Location = new System.Drawing.Point(481, 185);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(190, 166);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "VENDA";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.BackColor = System.Drawing.Color.Azure;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(481, 13);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(190, 166);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFornecedor.BackColor = System.Drawing.Color.Azure;
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedor.Location = new System.Drawing.Point(687, 13);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(190, 166);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.Text = "FORNECEDOR";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompra.BackColor = System.Drawing.Color.Azure;
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompra.Location = new System.Drawing.Point(899, 13);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(190, 166);
            this.btnCompra.TabIndex = 9;
            this.btnCompra.Text = "COMPRA";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompra.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnRelatorios);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Location = new System.Drawing.Point(1, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 87);
            this.panel2.TabIndex = 5;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorios.BackColor = System.Drawing.Color.Lavender;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(949, 23);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(193, 42);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relátorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // lblDataHorarioAU
            // 
            this.lblDataHorarioAU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataHorarioAU.AutoSize = true;
            this.lblDataHorarioAU.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDataHorarioAU.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHorarioAU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataHorarioAU.Location = new System.Drawing.Point(1180, 705);
            this.lblDataHorarioAU.Name = "lblDataHorarioAU";
            this.lblDataHorarioAU.Size = new System.Drawing.Size(0, 50);
            this.lblDataHorarioAU.TabIndex = 6;
            // 
            // tDataHoraAU
            // 
            this.tDataHoraAU.Enabled = true;
            this.tDataHoraAU.Tick += new System.EventHandler(this.tDataHoraAU_Tick);
            // 
            // AreaUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1330, 759);
            this.Controls.Add(this.lblDataHorarioAU);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnAcoes);
            this.Controls.Add(this.lblLogado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaUsuario";
            this.Text = "Area Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AreaUsuariocs_Load);
            this.pnAcoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnAcoes;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnInsumo;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnPlantacao;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnColheita;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnClienteJuridico;
        private System.Windows.Forms.Button btnClienteFisico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorios;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private System.Windows.Forms.Label lblDataHorarioAU;
        private System.Windows.Forms.Timer tDataHoraAU;
    }
}
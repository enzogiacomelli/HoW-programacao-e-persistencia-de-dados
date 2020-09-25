namespace handsOnWorkIII
{
    partial class telaInicial
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlterarNome = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNomeDoEstabelecimento = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(532, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVisualizarClientes});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Clientes";
            // 
            // btnVisualizarClientes
            // 
            this.btnVisualizarClientes.Name = "btnVisualizarClientes";
            this.btnVisualizarClientes.Size = new System.Drawing.Size(180, 22);
            this.btnVisualizarClientes.Text = "Visualizar";
            this.btnVisualizarClientes.Click += new System.EventHandler(this.btnVisualizarClientes_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVisualizarMesas,
            this.toolStripSeparator1,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "Mesas";
            // 
            // btnVisualizarMesas
            // 
            this.btnVisualizarMesas.Name = "btnVisualizarMesas";
            this.btnVisualizarMesas.Size = new System.Drawing.Size(180, 22);
            this.btnVisualizarMesas.Text = "Visualizar mesas";
            this.btnVisualizarMesas.Click += new System.EventHandler(this.btnVisualizarMesas_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Reservas";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesGeraisToolStripMenuItem,
            this.toolStripSeparator2,
            this.btnAlterarNome});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // configuraçõesGeraisToolStripMenuItem
            // 
            this.configuraçõesGeraisToolStripMenuItem.Name = "configuraçõesGeraisToolStripMenuItem";
            this.configuraçõesGeraisToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.configuraçõesGeraisToolStripMenuItem.Text = "Quantidade total de mesas";
            this.configuraçõesGeraisToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesGeraisToolStripMenuItem_Click);
            // 
            // btnAlterarNome
            // 
            this.btnAlterarNome.Name = "btnAlterarNome";
            this.btnAlterarNome.Size = new System.Drawing.Size(215, 22);
            this.btnAlterarNome.Text = "Nome do estabelecimento";
            this.btnAlterarNome.Click += new System.EventHandler(this.btnAlterarNome_Click);
            // 
            // labelNomeDoEstabelecimento
            // 
            this.labelNomeDoEstabelecimento.AutoSize = true;
            this.labelNomeDoEstabelecimento.Location = new System.Drawing.Point(12, 309);
            this.labelNomeDoEstabelecimento.Name = "labelNomeDoEstabelecimento";
            this.labelNomeDoEstabelecimento.Size = new System.Drawing.Size(130, 13);
            this.labelNomeDoEstabelecimento.TabIndex = 1;
            this.labelNomeDoEstabelecimento.Text = "Nome do estabelecimento";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // telaInicial
            // 
            this.ClientSize = new System.Drawing.Size(532, 331);
            this.Controls.Add(this.labelNomeDoEstabelecimento);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "telaInicial";
            this.Text = "Gerenciador de reservas";
            this.Load += new System.EventHandler(this.telaInicial_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarClientes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarMesas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesGeraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAlterarNome;
        private System.Windows.Forms.Label labelNomeDoEstabelecimento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


namespace ReCoMaS
{
    partial class Form_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMembrosDaRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDoSistemaCerberusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeEstabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosDaRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem,
            this.cadastroDeMembrosDaRedeToolStripMenuItem,
            this.cadastroDoSistemaCerberusToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // cadastroDeTiposDeEstabelecimentosToolStripMenuItem
            // 
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem.Name = "cadastroDeTiposDeEstabelecimentosToolStripMenuItem";
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem.Text = "Cadastro de tipos de estabelecimentos";
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem_Click);
            // 
            // cadastroDeMembrosDaRedeToolStripMenuItem
            // 
            this.cadastroDeMembrosDaRedeToolStripMenuItem.Name = "cadastroDeMembrosDaRedeToolStripMenuItem";
            this.cadastroDeMembrosDaRedeToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.cadastroDeMembrosDaRedeToolStripMenuItem.Text = "Cadastro de membros da rede";
            this.cadastroDeMembrosDaRedeToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMembrosDaRedeToolStripMenuItem_Click);
            // 
            // cadastroDoSistemaCerberusToolStripMenuItem
            // 
            this.cadastroDoSistemaCerberusToolStripMenuItem.Name = "cadastroDoSistemaCerberusToolStripMenuItem";
            this.cadastroDoSistemaCerberusToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.cadastroDoSistemaCerberusToolStripMenuItem.Text = "Cadastro do sistema Cerberus";
            this.cadastroDoSistemaCerberusToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoSistemaCerberusToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeEstabelecimentosToolStripMenuItem,
            this.membrosDaRedeToolStripMenuItem,
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // tiposDeEstabelecimentosToolStripMenuItem
            // 
            this.tiposDeEstabelecimentosToolStripMenuItem.Name = "tiposDeEstabelecimentosToolStripMenuItem";
            this.tiposDeEstabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.tiposDeEstabelecimentosToolStripMenuItem.Text = "Tipos de estabelecimentos";
            // 
            // membrosDaRedeToolStripMenuItem
            // 
            this.membrosDaRedeToolStripMenuItem.Name = "membrosDaRedeToolStripMenuItem";
            this.membrosDaRedeToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.membrosDaRedeToolStripMenuItem.Text = "Membros da rede";
            this.membrosDaRedeToolStripMenuItem.Click += new System.EventHandler(this.membrosDaRedeToolStripMenuItem_Click);
            // 
            // equipamentosCadastradosNoSistemaCerberusToolStripMenuItem
            // 
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem.Name = "equipamentosCadastradosNoSistemaCerberusToolStripMenuItem";
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem.Text = "Equipamentos cadastrados no sistema Cerberus";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Protector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeTiposDeEstabelecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMembrosDaRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDoSistemaCerberusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeEstabelecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membrosDaRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentosCadastradosNoSistemaCerberusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}


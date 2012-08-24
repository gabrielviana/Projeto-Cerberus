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
            this.cadastroDeCriminososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeTiposDeCrimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criminososCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCrimesCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCrimesOcorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaProtectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarUsuárioDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarUsuáriosDoProtectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesDoSistemaToolStripMenuItem,
            this.sobreOSistemaProtectorToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeTiposDeEstabelecimentosToolStripMenuItem,
            this.cadastroDeMembrosDaRedeToolStripMenuItem,
            this.cadastroDoSistemaCerberusToolStripMenuItem,
            this.cadastroDeCriminososToolStripMenuItem,
            this.cadastroDeTiposDeCrimesToolStripMenuItem,
            this.cadastroDeCrimesOcorridosToolStripMenuItem});
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
            this.equipamentosCadastradosNoSistemaCerberusToolStripMenuItem,
            this.criminososCadastradosToolStripMenuItem,
            this.tiposDeCrimesCadastradosToolStripMenuItem});
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
            // cadastroDeCriminososToolStripMenuItem
            // 
            this.cadastroDeCriminososToolStripMenuItem.Name = "cadastroDeCriminososToolStripMenuItem";
            this.cadastroDeCriminososToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cadastroDeCriminososToolStripMenuItem.Text = "Cadastro de criminosos";
            this.cadastroDeCriminososToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCriminososToolStripMenuItem_Click);
            // 
            // cadastroDeTiposDeCrimesToolStripMenuItem
            // 
            this.cadastroDeTiposDeCrimesToolStripMenuItem.Name = "cadastroDeTiposDeCrimesToolStripMenuItem";
            this.cadastroDeTiposDeCrimesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cadastroDeTiposDeCrimesToolStripMenuItem.Text = "Cadastro de tipos de crimes";
            // 
            // criminososCadastradosToolStripMenuItem
            // 
            this.criminososCadastradosToolStripMenuItem.Name = "criminososCadastradosToolStripMenuItem";
            this.criminososCadastradosToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.criminososCadastradosToolStripMenuItem.Text = "Criminosos cadastrados";
            // 
            // tiposDeCrimesCadastradosToolStripMenuItem
            // 
            this.tiposDeCrimesCadastradosToolStripMenuItem.Name = "tiposDeCrimesCadastradosToolStripMenuItem";
            this.tiposDeCrimesCadastradosToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.tiposDeCrimesCadastradosToolStripMenuItem.Text = "Tipos de crimes cadastrados";
            // 
            // cadastroDeCrimesOcorridosToolStripMenuItem
            // 
            this.cadastroDeCrimesOcorridosToolStripMenuItem.Name = "cadastroDeCrimesOcorridosToolStripMenuItem";
            this.cadastroDeCrimesOcorridosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cadastroDeCrimesOcorridosToolStripMenuItem.Text = "Cadastro de crimes ocorridos";
            this.cadastroDeCrimesOcorridosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCrimesOcorridosToolStripMenuItem_Click);
            // 
            // configuraçõesDoSistemaToolStripMenuItem
            // 
            this.configuraçõesDoSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarUsuárioDeAcessoToolStripMenuItem,
            this.pesquisarUsuáriosDoProtectorToolStripMenuItem});
            this.configuraçõesDoSistemaToolStripMenuItem.Name = "configuraçõesDoSistemaToolStripMenuItem";
            this.configuraçõesDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.configuraçõesDoSistemaToolStripMenuItem.Text = "Configurações";
            // 
            // sobreOSistemaProtectorToolStripMenuItem
            // 
            this.sobreOSistemaProtectorToolStripMenuItem.Name = "sobreOSistemaProtectorToolStripMenuItem";
            this.sobreOSistemaProtectorToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.sobreOSistemaProtectorToolStripMenuItem.Text = "Sobre o Protector";
            this.sobreOSistemaProtectorToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaProtectorToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // criarUsuárioDeAcessoToolStripMenuItem
            // 
            this.criarUsuárioDeAcessoToolStripMenuItem.Name = "criarUsuárioDeAcessoToolStripMenuItem";
            this.criarUsuárioDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.criarUsuárioDeAcessoToolStripMenuItem.Text = "Criar usuário de acesso";
            // 
            // pesquisarUsuáriosDoProtectorToolStripMenuItem
            // 
            this.pesquisarUsuáriosDoProtectorToolStripMenuItem.Name = "pesquisarUsuáriosDoProtectorToolStripMenuItem";
            this.pesquisarUsuáriosDoProtectorToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pesquisarUsuáriosDoProtectorToolStripMenuItem.Text = "Pesquisar usuários do Protector";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 273);
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
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCriminososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeTiposDeCrimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criminososCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCrimesCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCrimesOcorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaProtectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarUsuárioDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarUsuáriosDoProtectorToolStripMenuItem;
    }
}


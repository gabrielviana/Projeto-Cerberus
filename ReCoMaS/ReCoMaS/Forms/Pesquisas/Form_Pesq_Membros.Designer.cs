namespace ReCoMaS.Forms
{
    partial class Form_Pesq_Membros
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbxgeografico = new System.Windows.Forms.GroupBox();
            this.lbllatitude = new System.Windows.Forms.Label();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.lbllongitude = new System.Windows.Forms.Label();
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.gbxpessoais = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbldatainclusao = new System.Windows.Forms.Label();
            this.txtrazaosocial = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelcomercial = new System.Windows.Forms.TextBox();
            this.txttelcelular = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lbltipoestabelecimento = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lbltelcelular = new System.Windows.Forms.Label();
            this.lblrazaosocial = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltelcomercial = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdatainclusao = new System.Windows.Forms.DateTimePicker();
            this.rbmatricula = new System.Windows.Forms.RadioButton();
            this.rbnome = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblpesquisarpor = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.gbxgeografico.SuspendLayout();
            this.gbxpessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(448, 424);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // gbxgeografico
            // 
            this.gbxgeografico.Controls.Add(this.lbllatitude);
            this.gbxgeografico.Controls.Add(this.txtlatitude);
            this.gbxgeografico.Controls.Add(this.lbllongitude);
            this.gbxgeografico.Controls.Add(this.txtlongitude);
            this.gbxgeografico.Location = new System.Drawing.Point(11, 312);
            this.gbxgeografico.Name = "gbxgeografico";
            this.gbxgeografico.Size = new System.Drawing.Size(512, 86);
            this.gbxgeografico.TabIndex = 21;
            this.gbxgeografico.TabStop = false;
            this.gbxgeografico.Text = "Dados geográficos";
            // 
            // lbllatitude
            // 
            this.lbllatitude.AutoSize = true;
            this.lbllatitude.Location = new System.Drawing.Point(62, 43);
            this.lbllatitude.Name = "lbllatitude";
            this.lbllatitude.Size = new System.Drawing.Size(48, 13);
            this.lbllatitude.TabIndex = 10;
            this.lbllatitude.Text = "Latitude:";
            // 
            // txtlatitude
            // 
            this.txtlatitude.Location = new System.Drawing.Point(116, 40);
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.Size = new System.Drawing.Size(129, 20);
            this.txtlatitude.TabIndex = 9;
            // 
            // lbllongitude
            // 
            this.lbllongitude.AutoSize = true;
            this.lbllongitude.Location = new System.Drawing.Point(268, 43);
            this.lbllongitude.Name = "lbllongitude";
            this.lbllongitude.Size = new System.Drawing.Size(57, 13);
            this.lbllongitude.TabIndex = 9;
            this.lbllongitude.Text = "Longitude:";
            // 
            // txtlongitude
            // 
            this.txtlongitude.Location = new System.Drawing.Point(331, 40);
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.Size = new System.Drawing.Size(135, 20);
            this.txtlongitude.TabIndex = 10;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(367, 424);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // gbxpessoais
            // 
            this.gbxpessoais.Controls.Add(this.dtpdatainclusao);
            this.gbxpessoais.Controls.Add(this.comboBox1);
            this.gbxpessoais.Controls.Add(this.lbldatainclusao);
            this.gbxpessoais.Controls.Add(this.txtrazaosocial);
            this.gbxpessoais.Controls.Add(this.txtnome);
            this.gbxpessoais.Controls.Add(this.txttelcomercial);
            this.gbxpessoais.Controls.Add(this.txttelcelular);
            this.gbxpessoais.Controls.Add(this.txtendereco);
            this.gbxpessoais.Controls.Add(this.lbltipoestabelecimento);
            this.gbxpessoais.Controls.Add(this.txtmatricula);
            this.gbxpessoais.Controls.Add(this.lblmatricula);
            this.gbxpessoais.Controls.Add(this.lbltelcelular);
            this.gbxpessoais.Controls.Add(this.lblrazaosocial);
            this.gbxpessoais.Controls.Add(this.lblnome);
            this.gbxpessoais.Controls.Add(this.lbltelcomercial);
            this.gbxpessoais.Controls.Add(this.lblendereco);
            this.gbxpessoais.Location = new System.Drawing.Point(11, 74);
            this.gbxpessoais.Name = "gbxpessoais";
            this.gbxpessoais.Size = new System.Drawing.Size(512, 218);
            this.gbxpessoais.TabIndex = 20;
            this.gbxpessoais.TabStop = false;
            this.gbxpessoais.Text = "Dados pessoais";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lbldatainclusao
            // 
            this.lbldatainclusao.AutoSize = true;
            this.lbldatainclusao.Location = new System.Drawing.Point(277, 161);
            this.lbldatainclusao.Name = "lbldatainclusao";
            this.lbldatainclusao.Size = new System.Drawing.Size(90, 13);
            this.lbldatainclusao.TabIndex = 17;
            this.lbldatainclusao.Text = "Data de inclusão:";
            // 
            // txtrazaosocial
            // 
            this.txtrazaosocial.Location = new System.Drawing.Point(358, 29);
            this.txtrazaosocial.Name = "txtrazaosocial";
            this.txtrazaosocial.Size = new System.Drawing.Size(135, 20);
            this.txtrazaosocial.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(123, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(370, 20);
            this.txtnome.TabIndex = 3;
            // 
            // txttelcomercial
            // 
            this.txttelcomercial.Location = new System.Drawing.Point(123, 127);
            this.txttelcomercial.Name = "txttelcomercial";
            this.txttelcomercial.Size = new System.Drawing.Size(140, 20);
            this.txttelcomercial.TabIndex = 5;
            // 
            // txttelcelular
            // 
            this.txttelcelular.Location = new System.Drawing.Point(373, 127);
            this.txttelcelular.Name = "txttelcelular";
            this.txttelcelular.Size = new System.Drawing.Size(120, 20);
            this.txttelcelular.TabIndex = 6;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(123, 92);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(370, 20);
            this.txtendereco.TabIndex = 4;
            // 
            // lbltipoestabelecimento
            // 
            this.lbltipoestabelecimento.AutoSize = true;
            this.lbltipoestabelecimento.Location = new System.Drawing.Point(6, 161);
            this.lbltipoestabelecimento.Name = "lbltipoestabelecimento";
            this.lbltipoestabelecimento.Size = new System.Drawing.Size(111, 13);
            this.lbltipoestabelecimento.TabIndex = 8;
            this.lbltipoestabelecimento.Text = "Tipo estabelecimento:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(123, 29);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(145, 20);
            this.txtmatricula.TabIndex = 1;
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(62, 32);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(55, 13);
            this.lblmatricula.TabIndex = 1;
            this.lblmatricula.Text = "Matrícula:";
            // 
            // lbltelcelular
            // 
            this.lbltelcelular.AutoSize = true;
            this.lbltelcelular.Location = new System.Drawing.Point(281, 130);
            this.lbltelcelular.Name = "lbltelcelular";
            this.lbltelcelular.Size = new System.Drawing.Size(86, 13);
            this.lbltelcelular.TabIndex = 7;
            this.lbltelcelular.Text = "Telefone celular:";
            // 
            // lblrazaosocial
            // 
            this.lblrazaosocial.AutoSize = true;
            this.lblrazaosocial.Location = new System.Drawing.Point(281, 32);
            this.lblrazaosocial.Name = "lblrazaosocial";
            this.lblrazaosocial.Size = new System.Drawing.Size(71, 13);
            this.lblrazaosocial.TabIndex = 2;
            this.lblrazaosocial.Text = "Razão social:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(8, 63);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(111, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome do participante:";
            // 
            // lbltelcomercial
            // 
            this.lbltelcomercial.AutoSize = true;
            this.lbltelcomercial.Location = new System.Drawing.Point(17, 130);
            this.lbltelcomercial.Name = "lbltelcomercial";
            this.lbltelcomercial.Size = new System.Drawing.Size(100, 13);
            this.lbltelcomercial.TabIndex = 11;
            this.lbltelcomercial.Text = "Telefone comercial:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(15, 95);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(102, 13);
            this.lblendereco.TabIndex = 6;
            this.lblendereco.Text = "Endereço completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // dtpdatainclusao
            // 
            this.dtpdatainclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatainclusao.Location = new System.Drawing.Point(373, 159);
            this.dtpdatainclusao.Name = "dtpdatainclusao";
            this.dtpdatainclusao.Size = new System.Drawing.Size(120, 20);
            this.dtpdatainclusao.TabIndex = 8;
            this.dtpdatainclusao.Value = new System.DateTime(2012, 8, 6, 0, 0, 0, 0);
            // 
            // rbmatricula
            // 
            this.rbmatricula.AutoSize = true;
            this.rbmatricula.Location = new System.Drawing.Point(26, 32);
            this.rbmatricula.Name = "rbmatricula";
            this.rbmatricula.Size = new System.Drawing.Size(70, 17);
            this.rbmatricula.TabIndex = 22;
            this.rbmatricula.TabStop = true;
            this.rbmatricula.Text = "Matrícula";
            this.rbmatricula.UseVisualStyleBackColor = true;
            // 
            // rbnome
            // 
            this.rbnome.AutoSize = true;
            this.rbnome.Location = new System.Drawing.Point(102, 32);
            this.rbnome.Name = "rbnome";
            this.rbnome.Size = new System.Drawing.Size(53, 17);
            this.rbnome.TabIndex = 23;
            this.rbnome.TabStop = true;
            this.rbnome.Text = "Nome";
            this.rbnome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 24;
            // 
            // lblpesquisarpor
            // 
            this.lblpesquisarpor.AutoSize = true;
            this.lblpesquisarpor.Location = new System.Drawing.Point(24, 9);
            this.lblpesquisarpor.Name = "lblpesquisarpor";
            this.lblpesquisarpor.Size = new System.Drawing.Size(74, 13);
            this.lblpesquisarpor.TabIndex = 25;
            this.lblpesquisarpor.Text = "Pesquisar por:";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(436, 32);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 21);
            this.btnpesquisar.TabIndex = 26;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // Form_Pesq_Membros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 466);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.lblpesquisarpor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbnome);
            this.Controls.Add(this.rbmatricula);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gbxgeografico);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.gbxpessoais);
            this.Controls.Add(this.label1);
            this.Name = "Form_Pesq_Membros";
            this.Text = "Form_Pesq_Membros";
            this.gbxgeografico.ResumeLayout(false);
            this.gbxgeografico.PerformLayout();
            this.gbxpessoais.ResumeLayout(false);
            this.gbxpessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox gbxgeografico;
        private System.Windows.Forms.Label lbllatitude;
        private System.Windows.Forms.TextBox txtlatitude;
        private System.Windows.Forms.Label lbllongitude;
        private System.Windows.Forms.TextBox txtlongitude;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.GroupBox gbxpessoais;
        private System.Windows.Forms.DateTimePicker dtpdatainclusao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbldatainclusao;
        private System.Windows.Forms.TextBox txtrazaosocial;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelcomercial;
        private System.Windows.Forms.TextBox txttelcelular;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lbltipoestabelecimento;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lbltelcelular;
        private System.Windows.Forms.Label lblrazaosocial;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltelcomercial;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbmatricula;
        private System.Windows.Forms.RadioButton rbnome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblpesquisarpor;
        private System.Windows.Forms.Button btnpesquisar;
    }
}
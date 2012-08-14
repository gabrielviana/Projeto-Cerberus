namespace ReCoMaS.Forms
{
    partial class Form_Cad_Cerberus
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
            this.txtnumserie = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblnumserie = new System.Windows.Forms.Label();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.cbxmatricula = new System.Windows.Forms.ComboBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumserie
            // 
            this.txtnumserie.Location = new System.Drawing.Point(124, 85);
            this.txtnumserie.Name = "txtnumserie";
            this.txtnumserie.Size = new System.Drawing.Size(131, 20);
            this.txtnumserie.TabIndex = 3;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(124, 115);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(131, 20);
            this.txtmodelo.TabIndex = 4;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(124, 56);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(131, 20);
            this.txtIMEI.TabIndex = 2;
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(61, 29);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(55, 13);
            this.lblmatricula.TabIndex = 4;
            this.lblmatricula.Text = "Matrícula:";
            // 
            // lblnumserie
            // 
            this.lblnumserie.AutoSize = true;
            this.lblnumserie.Location = new System.Drawing.Point(30, 88);
            this.lblnumserie.Name = "lblnumserie";
            this.lblnumserie.Size = new System.Drawing.Size(87, 13);
            this.lblnumserie.TabIndex = 5;
            this.lblnumserie.Text = "Número de série:";
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(39, 59);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(77, 13);
            this.lblIMEI.TabIndex = 6;
            this.lblIMEI.Text = "IMEI Cerberus:";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(13, 118);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(104, 13);
            this.lblmodelo.TabIndex = 7;
            this.lblmodelo.Text = "Modelo do aparelho:";
            // 
            // cbxmatricula
            // 
            this.cbxmatricula.FormattingEnabled = true;
            this.cbxmatricula.Location = new System.Drawing.Point(124, 26);
            this.cbxmatricula.Name = "cbxmatricula";
            this.cbxmatricula.Size = new System.Drawing.Size(131, 21);
            this.cbxmatricula.TabIndex = 1;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(67, 168);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(148, 168);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // Form_Cad_Cerberus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 218);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.cbxmatricula);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblIMEI);
            this.Controls.Add(this.lblnumserie);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtnumserie);
            this.Name = "Form_Cad_Cerberus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro no sistema Cerberus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumserie;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblnumserie;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.ComboBox cbxmatricula;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;

    }
}
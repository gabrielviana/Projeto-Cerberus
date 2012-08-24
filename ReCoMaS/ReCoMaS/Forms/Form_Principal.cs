using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReCoMaS.Forms;
using ReCoMaS.Forms.Cadastros;

namespace ReCoMaS
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void cadastroDeTiposDeEstabelecimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tipos_Estabelecimento callTE = new Form_Tipos_Estabelecimento();
            callTE.Show();
        }

        private void cadastroDeMembrosDaRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Membros callMR = new Form_Cad_Membros();
            callMR.Show();
        }

        private void cadastroDoSistemaCerberusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Cerberus callSC = new Form_Cad_Cerberus();
            callSC.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void membrosDaRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pesq_Membros callFM = new Form_Pesq_Membros();
            callFM.Show();
        }

        private void cadastroDeCrimesOcorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Crimes callCC = new Form_Cad_Crimes();
            callCC.Show();
        }

        private void cadastroDeCriminososToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Criminoso callCCr = new Form_Cad_Criminoso();
            callCCr.Show();
        }

        private void sobreOSistemaProtectorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

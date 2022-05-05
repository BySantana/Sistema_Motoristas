using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula80_Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //public static List<Classes.Motorista> motoristas = Classes.Motorista.MotoristasRepository();
        public static Classes.ControleMotoristas motoristas1 = new Classes.ControleMotoristas();

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RelatorioViagens relatorio = new Telas.RelatorioViagens();
            relatorio.ShowDialog();
        }
        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FromMotorista fromMotorista = new Telas.FromMotorista();
            fromMotorista.ShowDialog();
        }
        private void ckbOn_1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOn_1.Checked)
            {
                ckbViagem_1.Enabled = true;
            }
            else if(ckbOn_1.Checked == false)
            {
                ckbViagem_1.Enabled = false;
            }
        }

        private void ckbViagem_1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbViagem_1.Checked)
            {
                txtValor_1.Enabled = true;
                btnConfirmar_1.Enabled = true;
            }
            else if (ckbViagem_1.Checked == false)
            {
                txtValor_1.Enabled = false;
                btnConfirmar_1.Enabled = false;
            }
        }

        private void btnConfirmar_1_Click(object sender, EventArgs e)
        {
            foreach(Classes.Motorista motorista in motoristas1.ListMotoristas)
            {
                if(motorista.Nome == motoristas1.ListMotoristas[0].Nome)
                {
                    motoristas1.CalcularViagens(label1.Text, double.Parse(txtValor_1.Text));
                    MessageBox.Show("VIAGEM INICIADA!", "AVISO");
                }
            }
        }

        private void ckbOn_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOn_2.Checked)
            {
                ckbViagem_2.Enabled = true;
            }
            else if (ckbOn_2.Checked == false)
            {
                ckbViagem_2.Enabled = false;
            }
        }

        private void ckbViagem_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbViagem_2.Checked)
            {
                txtValor_2.Enabled = true;
                btnConfirmar_2.Enabled = true;
            }
            else if (ckbViagem_2.Checked == false)
            {
                txtValor_2.Enabled = false;
                btnConfirmar_2.Enabled = false;
            }
        }

        private void btnConfirmar_2_Click(object sender, EventArgs e)
        {
            foreach (Classes.Motorista motorista in motoristas1.ListMotoristas)
            {
                if (motorista.Nome == motoristas1.ListMotoristas[1].Nome)
                {
                    motoristas1.CalcularViagens("Motorista 2", double.Parse(txtValor_2.Text));
                    MessageBox.Show("VIAGEM INICIADA!", "AVISO");
                }
            }
        }

        private void ckbOn_3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOn_3.Checked)
            {
                ckbViagem_3.Enabled = true;
            }
            else if (ckbOn_3.Checked == false)
            {
                ckbViagem_3.Enabled = false;
            }
        }

        private void ckbViagem_3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbViagem_3.Checked)
            {
                txtValor_3.Enabled = true;
                btnConfirmar_3.Enabled = true;
            }
            else if (ckbViagem_3.Checked == false)
            {
                txtValor_3.Enabled = false;
                btnConfirmar_3.Enabled = false;
            }
        }

        private void btnConfirmar_3_Click(object sender, EventArgs e)
        {
            foreach (Classes.Motorista motorista in motoristas1.ListMotoristas)
            {
                if (motorista.Nome == motoristas1.ListMotoristas[2].Nome)
                {
                    motoristas1.CalcularViagens("Motorista 3", double.Parse(txtValor_3.Text));
                    MessageBox.Show("VIAGEM INICIADA!", "AVISO");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula80_Exercicio.Telas
{
    public partial class RelatorioViagens : Form
    {
        public RelatorioViagens()
        {
            InitializeComponent();
        }
        //List<Classes.Motorista> motoristas = Form1.motoristas;
        Classes.ControleMotoristas motoristas1 = new Classes.ControleMotoristas(); 
        private void button1_Click(object sender, EventArgs e)
        {

            txtViagens_1.Text = Form1.motoristas1.ListMotoristas[0].QtdeViagens.ToString();
            txtValor_1.Text = Form1.motoristas1.ListMotoristas[0].ValorTotal.ToString();

            txtViagens_2.Text = Form1.motoristas1.ListMotoristas[1].QtdeViagens.ToString();
            txtValor_2.Text = Form1.motoristas1.ListMotoristas[1].ValorTotal.ToString();

            txtViagens_3.Text = Form1.motoristas1.ListMotoristas[2].QtdeViagens.ToString();
            txtValor_3.Text = Form1.motoristas1.ListMotoristas[2].ValorTotal.ToString();
        }
    }
}

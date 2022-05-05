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
        List<Classes.Motorista> motoristas = Form1.motoristas;
        private void button1_Click(object sender, EventArgs e)
        {

            txtViagens_1.Text = motoristas[0].QtdeViagens.ToString();
            txtValor_1.Text = motoristas[0].ValorTotal.ToString();

            txtViagens_2.Text = motoristas[1].QtdeViagens.ToString();
            txtValor_2.Text = motoristas[1].ValorTotal.ToString();

            txtViagens_3.Text = motoristas[2].QtdeViagens.ToString();
            txtValor_3.Text = motoristas[2].ValorTotal.ToString();
        }
    }
}

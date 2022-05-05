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
    public partial class FromMotorista : Form
    {
        public FromMotorista()
        {
            InitializeComponent();
        }
        //List<Classes.Motorista> motoristas = Form1.motoristas;
        
        private void FromMotorista_Load(object sender, EventArgs e)
        {
            cbListaMotoristas.Items.AddRange(Form1.motoristas1.ListMotoristas.ToArray());
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.motoristas1.ListMotoristas.Count; i++)
            {
                if (cbListaMotoristas.Text == Form1.motoristas1.ListMotoristas[i].Nome)
                {
                    txtValor.Text = Form1.motoristas1.ListMotoristas[i].ValorTotal.ToString();
                    txtViagens.Text = Form1.motoristas1.ListMotoristas[i].QtdeViagens.ToString();
                }
            }
        }
    }
}

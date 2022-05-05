using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula80_Exercicio.Classes
{
    public class ControleMotoristas
    {
        public List<Motorista> ListMotoristas = Classes.Motorista.MotoristasRepository();

        public List<Motorista> AdicionarMotorista(string nome)
        {
            ListMotoristas.Add(new Motorista(nome, 0, 0));
            return ListMotoristas;
        }

        public void CalcularViagens(string nome, double valor)
        {
            foreach(Motorista motorista in ListMotoristas)
            {
                if(motorista.Nome == nome)
                {
                    motorista.QtdeViagens++;
                    motorista.ValorTotal += valor;
                }
            }
            //return ListMotoristas;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula80_Exercicio.Classes
{
    public class Motorista
    {
        public string Nome { get; set; }
        public int QtdeViagens { get; set; }
        public double ValorTotal { get; set; }


        public Motorista(string nome, int qtdeViagens, double valorTotal)
        {
            Nome = nome;
            QtdeViagens = qtdeViagens;
            ValorTotal = valorTotal;
        }

        public static List<Motorista> MotoristasRepository()
        {
            List<Motorista> MotoristaList = new List<Motorista>();
            MotoristaList.Add(new Motorista("Motorista 1", 0, 0));
            MotoristaList.Add(new Motorista("Motorista 2", 0, 0));
            MotoristaList.Add(new Motorista("Motorista 3", 0, 0));
            return MotoristaList;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}


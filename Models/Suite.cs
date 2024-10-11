using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_de_um_Hotel.Models
{
    public class Suite
    {

        public Suite (string tiposuite, int capacidade, decimal valordiaria)
        {
            TipoSuite = tiposuite;
            Capacidade = capacidade;
            ValorDiaria = valordiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_de_um_Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) 
        {
            DiasReservados = diasReservados;         
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            } else
            {
                throw new Exception("A quantidade de Hospedes é superior ao perminito na suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            Console.WriteLine("A quantidade de hospedes cadastrados são: " + Hospedes.Count);
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90M;
            } 
            Console.WriteLine($"Total {valorTotal.ToString("0.00")}");
            return valorTotal;
        }
    }


}

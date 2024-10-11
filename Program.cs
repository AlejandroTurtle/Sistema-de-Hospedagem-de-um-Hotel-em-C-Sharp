
using Sistema_de_Hospedagem_de_um_Hotel.Models;

List<Pessoa> Hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Alejandro", "Gomes");

Pessoa p2 = new Pessoa("Larissa", "Campos");

Console.WriteLine($"Os hospedes cadastrados são {p1.Nome} e {p2.Nome}");

Hospedes.Add(p1);
Hospedes.Add(p2);

Reserva reserva = new Reserva(diasReservados: 4);

Suite suite = new Suite("Suite luxo", 2, 200.00M);

reserva.CadastrarSuite(suite);

reserva.CadastrarHospedes(Hospedes);

reserva.ObterQuantidadeHospedes(); 

reserva.CalcularValorDiaria();
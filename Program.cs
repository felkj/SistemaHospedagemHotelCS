using SistemaHospedagemHotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Felipe", "Silva");
Pessoa p2 = new Pessoa("teste", "Vlogs");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premium", 2, 100.00m);

Reserva reserva = new Reserva(10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diaria: {reserva.CalcularValorDiaria().ToString("C")}");


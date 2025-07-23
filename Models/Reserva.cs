using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Reserva
    {
        private List<Pessoa> _hospedes;
        private Suite _suite;
        private int _diasReservados;

        //Getters and Setters
        public List<Pessoa> Hospedes
        {
            get => _hospedes;
            set => _hospedes = value;
        }
        public Suite Suite
        {
            get => _suite;
            set => _suite = value;
        }
        public int DiasReservados
        {
            get => _diasReservados;
            set => _diasReservados = value;
        }

        //métodos abaixo

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new ArgumentException("A quantidade de hospedes excedeu a capacidade da hospedagem!");
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados < 10)
            {
                return valorDiaria / DiasReservados;
            }
            return (valorDiaria * 0.9m) / DiasReservados; // 10% de desconto para reservas acima de 10 dias
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Suite
    {
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        //Getters e Setters
        public string TipoSuite
        {
            get => _tipoSuite;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Tipo da Suite não pode ser vazio!");
                }

                _tipoSuite = value;
            }
        }
        public int Capacidade
        {
            get => _capacidade;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacidade não pode ser zero!");
                }
                else if (value == null)
                {
                    throw new ArgumentException("Capacidade não pode ser nula!");
                }

                _capacidade = value;
            }
        }
        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacidade não pode ser zero!");
                }
                else if (value == null)
                {
                    throw new ArgumentException("Capacidade não pode ser nula!");
                }

                _valorDiaria = value;
            }
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
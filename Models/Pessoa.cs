using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;

        //Getters e Setters
        public string Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio!");
                }

                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobrenome não pode ser vazio!");
                }

                _sobrenome = value;
            }
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

    }
}
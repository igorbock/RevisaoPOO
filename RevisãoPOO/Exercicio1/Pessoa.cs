using System;
using System.Collections.Generic;
using System.Text;

namespace RevisãoPOO
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Altura { get; private set; }

        public Pessoa(string nome, DateTime dataNascimento, decimal altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public string DadosPessoa()
        {
            return $"Nome: {Nome} --- Data de Nascimento: {DataNascimento.Date.Day}/{DataNascimento.Date.Month}/{DataNascimento.Date.Year} --- Altura: {Altura}";
        }

        public string CalcularIdade()
        {
            if(DataNascimento.Month > DateTime.Now.Month && DataNascimento.Day > DateTime.Now.Day)
            {
                return $"O(A) {Nome} tem {DateTime.Now.Year - DataNascimento.Year - 1} anos.";
            }
            else
            {
                return $"O(A) {Nome} tem {DateTime.Now.Year - DataNascimento.Year} anos.";
            }
            
        }
    }
}

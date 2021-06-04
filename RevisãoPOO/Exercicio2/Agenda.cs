using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevisãoPOO
{
    public class Agenda
    {
        Pessoa[] pessoa = new Pessoa[10];

        public void armazenaPessoas(string nome, int idade, float altura)
        {
            for(int i = 0;  i < 10; i++)
            {
                int anoNascimento = DateTime.Now.Year - idade;
                DateTime dataNascimento = DateTime.Today.AddYears(anoNascimento);
                pessoa[i] = new Pessoa(nome, dataNascimento, Convert.ToDecimal(altura));
                //Console.WriteLine("Digite o nome da pessoa: ");
                //nome = Console.ReadLine();
                //Console.WriteLine("Digite a idade: ");
                //idade = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite a altura: ");
                //altura = float.Parse(Console.ReadLine());
            }
        }

        public void removePessoas(string nome)
        {
            for(int i = 0; i < 10; i++)
            {
                if (pessoa[i].Nome.Equals(nome))
                {
                    pessoa[i] = null;
                }
            }
        }

        public int buscaPessoa(string nome)
        {
            for(int i = 0; i < 10; i++)
            {
                if (pessoa[i].Nome.Equals(nome))
                {
                    return i;
                }
            }
            return 0;
        }

        public void imprimeAgenda()
        {
            Console.WriteLine("Dados das pessoas\n");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} -- Nome: {pessoa[i].Nome}      Idade: {DateTime.Now.Year - pessoa[i].DataNascimento.Year}      Altura: {pessoa[i].Altura}");
            }
        }

        public void imprimePessoa(int index)
        {
            Console.WriteLine($"{index} -- Nome: {pessoa[index].Nome}      Idade: {DateTime.Now.Year - pessoa[index].DataNascimento.Year}      Altura: {pessoa[index].Altura}");
        }
    }
}

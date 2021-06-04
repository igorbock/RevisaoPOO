using System;
using System.Collections.Generic;
using System.Text;

namespace RevisãoPOO
{
    public class Elevador
    {
        private int AndarAtual { get; set; }
        private int TotalAndares { get; set; }
        private int CapacidadeMaxima { get; set; }
        private int OcupacaoAtual { get; set;  }

        public void Inicializa(int capacidadeMaxima, int totalAndares)
        {
            TotalAndares        = totalAndares;
            CapacidadeMaxima    = capacidadeMaxima;
        }

        public bool Entra(int numeroPessoas)
        {
            if(OcupacaoAtual + numeroPessoas <= CapacidadeMaxima && OcupacaoAtual != CapacidadeMaxima)
            {
                OcupacaoAtual += numeroPessoas;
                return true;
            }
            return false;
        }

        public bool Sai(int numeroPessoas)
        {
            if (OcupacaoAtual > 0 && numeroPessoas < OcupacaoAtual)
            {
                OcupacaoAtual -= numeroPessoas;
                return true;
            }
            return false;
        }

        public bool Sobe(int andares)
        {
            if(andares <= TotalAndares && AndarAtual != TotalAndares && AndarAtual + andares <= TotalAndares)
            {
                AndarAtual += andares;
                return true;
            }
            return false;
        }

        public bool Desce(int andares)
        {
            if(AndarAtual != 0 && AndarAtual - andares >= 0)
            {
                AndarAtual -= andares;
                return true;
            }
            return false;
        }
    }
}

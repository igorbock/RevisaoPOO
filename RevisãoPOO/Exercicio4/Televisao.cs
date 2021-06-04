using System;
using System.Collections.Generic;
using System.Text;

namespace RevisãoPOO
{
    public abstract class Televisao
    {
        protected int Volume { get; set; }
        protected string[] Canais = new string[10] { "Globo", "SBT", "Record", "RedeVida", "Discovery", "HBO", "TeleCine", "Gloob", "RedeTV", "GloboNews"};
        protected int index = 0;

        public virtual void AumentarVolume()
        {
            if (Volume < 100 && Volume >= 0)
            {
                Volume++;
            }
            else
            {
                Console.WriteLine("Volume no máximo.");
            }
        }
        public virtual void DiminuirVolume()
        {
            if (Volume <= 100 && Volume > 0)
            {
                Volume--;
            }
            else
            {
                Console.WriteLine("Volume no mínimo.");
            }
        }

        public virtual void TrocarCanal(bool trocar)
        {
            if (trocar && index >= 0 && index < 9)
            {
                index++;
                Console.WriteLine($"Canal selecionado: {Canais[index]}");
            }
            else if(trocar == false && index <= 9 && index > 0)
            {
                index--;
                Console.WriteLine($"Canal selecionado: {Canais[index]}");
            }
        }

        public virtual void TrocarCanal(int i)
        {
            index = i;
            Console.WriteLine($"Canal selecionado: {Canais[index]}");
        }
    }
}

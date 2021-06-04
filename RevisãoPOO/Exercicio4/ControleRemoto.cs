using System;
using System.Collections.Generic;
using System.Text;

namespace RevisãoPOO
{
    public class ControleRemoto : Televisao
    {
        public override void AumentarVolume()
        {
            base.AumentarVolume();
            Console.WriteLine($"Volume aumentado para {Volume}");
        }

        public override void DiminuirVolume()
        {
            base.DiminuirVolume();
            Console.WriteLine($"Volume diminuido para {Volume}");
        }

        public override void TrocarCanal(bool trocar)
        {
            base.TrocarCanal(trocar);
        }

        public override void TrocarCanal(int i)
        {
            base.TrocarCanal(i);
        }


        public void Consultar()
        {
            Console.WriteLine($"Canal: {Canais[index]}\nVolume: {Volume}");
        }
    }
}

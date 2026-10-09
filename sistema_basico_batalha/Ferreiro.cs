using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_basico_batalha
{
    internal class Ferreiro
    {
        private int vida = 100;

        public int MelhorarArma(int poderAtualArma)
        {



            poderAtualArma += 50;



            return poderAtualArma;
        }
    }
}

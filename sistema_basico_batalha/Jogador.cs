using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_basico_batalha
{
    internal class Jogador
    {
        private int vida = 100;

        public int ReceberDano(int DanoNivelArma)
        {

            if (DanoNivelArma > vida)
            {
                vida = 0;
            }
            else if (vida > 0)
            {

                vida -= DanoNivelArma;
            }

            return DanoNivelArma;
        }
        public int ObterVida()
        {

            return vida;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_basico_batalha
{
    public partial class Form1 : Form
    {
        Jogador player1 = new Jogador();
        Jogador player2 = new Jogador();

        int poderDaMinhaEspada = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtacarP1_Click(object sender, EventArgs e)
        {
            player1.ReceberDano(poderDaMinhaEspada);
            lblVidaP1.Text = $"Vida P1: {player1.ObterVida()}";
        }

        private void btnAtacarP2_Click(object sender, EventArgs e)
        {
            player2.ReceberDano(poderDaMinhaEspada);
            lblVidaP2.Text = $"Vida P2: {player2.ObterVida()}";
        }

        private void btnVisitarFerreiro_Click(object sender, EventArgs e)
        {
            Ferreiro ferreiro = new Ferreiro();
            poderDaMinhaEspada = ferreiro.MelhorarArma(poderDaMinhaEspada);


            lblPoderEspada.Text = $"Poder da sua Espada: {poderDaMinhaEspada}";
        }
    }
}

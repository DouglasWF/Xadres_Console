using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }
    }
}

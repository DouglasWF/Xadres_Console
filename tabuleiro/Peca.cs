namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.posicao = null;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}

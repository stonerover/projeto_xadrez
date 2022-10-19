using tabuleiro;

namespace xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //uma casa superior esquerdo
            pos.definirValores(tab.linhas - 1, tab.colunas - 2);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }
            
            //uma casa superior direito
            pos.definirValores(tab.linhas - 1, tab.colunas + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }
            
            //uma casa inferior esquerdo
            pos.definirValores(tab.linhas + 1, tab.colunas - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }
            
            //uma casa inferior direito
            pos.definirValores(tab.linhas + 1, tab.colunas + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }

            //duas casas superior esquerdo
            pos.definirValores(tab.linhas - 2, tab.colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }

            //duas casas superior direito
            pos.definirValores(tab.linhas - 2, tab.colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }

            //duas casas inferior esquerdo
            pos.definirValores(tab.linhas + 2, tab.colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }

            //duas casas inferior direito
            pos.definirValores(tab.linhas - 2, tab.colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
            }

            return mat;
        }
    }
}

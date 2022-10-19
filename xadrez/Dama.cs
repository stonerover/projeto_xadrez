using tabuleiro;

namespace xadrez
{
    internal class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base (tab, cor)
        {

        }

        public override string ToString()
        {
            return "D";
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

            //diagonal superior esquerda
            pos.definirValores(tab.linhas - 1, tab.colunas - 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[tab.linhas, tab.colunas] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas - 1, tab.colunas - 1);
            }

            //Acima
            pos.definirValores(tab.linhas - 1, tab.colunas);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas - 1, tab.colunas);
            }

            //diagonal superior direita
            pos.definirValores(tab.linhas - 1, tab.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas - 1, tab.colunas + 1);
            }

            //direita
            pos.definirValores(tab.linhas, tab.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas, tab.colunas + 1);
            }

            //diagonal inferior direita
            pos.definirValores(tab.linhas + 1, tab.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas + 1, tab.colunas + 1);
            }

            //abaixo
            pos.definirValores(tab.linhas + 1, tab.colunas);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas + 1, tab.colunas);
            }

            //diagonal inferior esquerda
            pos.definirValores(tab.linhas + 1, tab.colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas + 1, tab.colunas - 1);
            }

            //esquerda
            pos.definirValores(tab.linhas, tab.colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(tab.linhas, tab.colunas - 1);
            }

            return mat;
        }
    }
}

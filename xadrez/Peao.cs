using System.Text.RegularExpressions;
using tabuleiro;

namespace xadrez
{
    internal class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base (tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Movimentos das peças brancas
            if(cor == Cor.Branca)
            {
                //Mover para frente 
                pos.definirValores(tab.linhas - 1, tab.colunas);
                if(tab.posicaoValida(pos) && livre(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //Primeiro movimento peao (pode andar duas casas se for o primeiro movimento) 
                pos.definirValores(tab.linhas - 2, tab.colunas);
                if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //Captura Peao (pode capturar somente na diagonal)
                //diagonal esquerda 
                pos.definirValores(tab.linhas - 1, tab.colunas - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //diagonal direita 
                pos.definirValores(tab.linhas - 1, tab.colunas + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }
            }

            //Movimento das peças pretas
            else
            {
                //Mover para frente
                pos.definirValores(tab.linhas + 1, tab.colunas);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //Primeiro movimento peao (pode andar duas casas se for o primeiro movimento)
                pos.definirValores(tab.linhas + 2, tab.colunas);
                if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //Captura Peao (pode capturar somente na diagonal)
                //diagonal esquerda 
                pos.definirValores(tab.linhas + 1, tab.colunas - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }

                //diagonal direita 
                pos.definirValores(tab.linhas + 1, tab.colunas + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[tab.linhas, tab.colunas] = true;
                }
            }

            return mat;
        }
    }
}

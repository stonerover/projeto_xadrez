using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Tabuleiro Tab { get; set; }
        public Cor Cor { get; set; }
        public Rei(Tabuleiro tab, Cor cor) : base (tab, cor)
        {
            Tab = tab;
            Cor = cor;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}

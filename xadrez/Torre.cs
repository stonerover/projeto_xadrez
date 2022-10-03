using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Tabuleiro Tab { get; set; }
        public Cor Cor { get; set; }
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            Tab = tab;
            Cor = cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}

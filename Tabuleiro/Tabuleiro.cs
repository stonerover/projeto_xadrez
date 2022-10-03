namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int Linhas, int Colunas)
        {
            linhas = Linhas;
            colunas = Colunas;
            pecas = new Peca[Linhas, Colunas];
        }
    }
}

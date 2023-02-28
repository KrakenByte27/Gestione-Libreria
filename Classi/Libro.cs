namespace Gestione_Libreria.Classi
{
    class Libro
    {
        public Libro(string titolo1, string autore1, double prezzo1, int copie1, int copievendute1, Libro next1)
        {
            Titolo = titolo1;
            Autore = autore1;
            Prezzo = prezzo1;
            Copie = copie1;
            Copievendute=copievendute1;
            Next = next1;
        }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public double Prezzo { get; set; }
        public int Copie { get; set; }
        public int Copievendute { get; set; }
        public Libro Next { get; set; }
    }
}

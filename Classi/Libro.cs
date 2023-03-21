namespace Gestione_Libreria.Classi
{
    class Libro
    {
        public Libro(string titolo1, string autore1, decimal prezzo1)
        {
            Titolo = titolo1;
            Autore = autore1;
            Prezzo = prezzo1;
        }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public decimal Prezzo { get; set; }
    }
}

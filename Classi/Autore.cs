namespace Gestione_Libreria.Classi
{
    class Autore
    {
        public Autore(string nome1, string cognome1, string nazione1, Autore next1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Nazionalita = nazione1;
            Next = next1;
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazionalita { get; set; }
        public Autore Next { get; set; }
    }
}

namespace Gestione_Libreria.Classi
{
    class ListaLibri
    {
        Libro testa;
        bool found = false;

        public ListaLibri()
        {
            testa = new("", "", 0, 0,0, null);
            testa.Next = null;
        }

        #region Funzioni

        public void Inserimento(Libro item1)
        {
            Libro p1;
            Libro inserito = item1;

            p1 = testa;
            found = false;
            do
            {
                if (p1 == null)
                {
                    p1 = inserito;
                    found = true;
                    testa = p1;
                }
                else if (p1.Next == null)
                {
                    p1.Next = inserito;
                    found = true;
                }
                else if (p1.Next != null)
                {
                    p1 = p1.Next;
                }
            }
            while (!found);
        }

        public void Aggiornamento(Libro item1)
        {
            Libro p1;

            p1 = testa;
            found = false;
            do
            {
                if (p1.Titolo == item1.Titolo)
                {
                    p1.Autore = item1.Autore;
                    p1.Prezzo = item1.Prezzo;
                    p1.Copie = item1.Copie;
                    p1.Copievendute= item1.Copievendute;
                    found = true;
                }
                else if (p1.Titolo != item1.Titolo)
                {
                    p1 = p1.Next;
                    found = false;
                }
            }
            while (!found);

        }

        public bool Rimozione(string item1)
        {
            Libro p1, p2;
            bool esito = false;

            p1 = testa;
            p2 = p1;
            found = false;

            do
            {
                if (p1.Next == null)
                {
                    esito = false;
                    found = true;
                }
                else
                {
                    if (p1.Next.Titolo == item1)
                    {
                        p2 = p1.Next.Next;
                        p1.Next = p2;
                        found = true;
                        esito = true;
                    }
                    else if (p1.Next.Titolo != item1)
                    {
                        p2 = p1;
                        p1 = p1.Next;
                        found = false;
                    }
                }
            }
            while (!found);

            return esito;
        }
        public List<Libro> ListaCompleta()
        {
            List<Libro> listacompleta = new();
            bool end = false;
            Libro p1;

            p1 = testa;

            do
            {
                if (p1 == null) end = true;
                else
                {
                    if (p1.Titolo == "")
                    {
                        p1 = p1.Next;
                    }
                    else
                    {
                        if (p1.Next == null)
                        {
                            end = true;
                            listacompleta.Add(p1);
                        }
                        else
                        {
                            end = false;
                            listacompleta.Add(p1);
                            p1 = p1.Next;
                        }
                    }
                }
            }
            while (!end);

            return listacompleta;
        }
        /*
        public List<string> ListaSquadre()
        {
            List<string> listasquadre = new();
            bool end = false;
            Libro p1;
            p1 = testa;

            do
            {
                if (p1 == null) end = true;
                else
                {
                    if (p1.Autore == "")
                    {
                        p1 = p1.Next;
                    }
                    else
                    {
                        if (p1.Next == null)
                        {
                            if (!listasquadre.Contains(p1.Autore))
                            {
                                end = true;
                                listasquadre.Add(p1.Autore);
                            }
                            else end = true;
                        }
                        else
                        {
                            if (!listasquadre.Contains(p1.Autore))
                            {
                                end = false;
                                listasquadre.Add(p1.Autore);
                                p1 = p1.Next;
                            }
                            else
                            {
                                end = false;
                                p1 = p1.Next;
                            }
                        }
                    }
                }
            }
            while (!end);

            return listasquadre;
        }
        */
        #endregion

        #region Altro

        public string[] Ricerca(string itemScelto)
        {
            Libro p1;

            string[] datiTotali = new string[4];

            p1 = testa;

            found = false;

            if (p1.Next != null)
            {
                do
                {
                    if (p1.Titolo == itemScelto)
                    {
                        found = true;
                        datiTotali[0] = p1.Autore;
                        datiTotali[1] = Convert.ToString(p1.Prezzo);
                        datiTotali[2] = Convert.ToString(p1.Copie);
                        datiTotali[3] = Convert.ToString(p1.Copievendute);

                    }
                    else if (p1.Titolo != itemScelto)
                    {
                        p1 = p1.Next;
                        found = false;
                    }
                }
                while (!found);
            }

            return datiTotali;
        }

        public List<Libro> RicercaSquadra(string nomesquadra)
        {
            List<Libro> squadra = new();
            Libro p1;

            p1 = testa;
            found = false;
            if (p1.Next != null)
            {
                do
                {
                    if (p1.Autore == nomesquadra)
                    {
                        if (p1.Next == null)
                        {
                            found = true;
                            squadra.Add(p1);
                        }
                        else
                        {
                            found = false;
                            squadra.Add(p1);
                            p1 = p1.Next;
                        }
                    }
                    else if (p1.Autore != nomesquadra)
                    {
                        if (p1.Next == null)
                        {
                            found = true;
                        }
                        else
                        {
                            p1 = p1.Next;
                            found = false;
                        }

                    }
                }
                while (!found);
            }

            return squadra;
        }



        #endregion
    }
}
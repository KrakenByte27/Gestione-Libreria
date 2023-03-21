using Gestione_Libreria.Classi;

namespace Gestione_Libreria
{
    public partial class homeForm : Form
    {
        List<Libro> libreria1 = new List<Libro>();

        public homeForm()
        {
            InitializeComponent();
        }

        #region Bottoni

        private void aggiugniButton_Click(object sender, EventArgs e)
        {
            bool checktitolo, checkautore, checkprezzo;

            if (titoloTextBox.Texts == "")
            {
                titoloTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checktitolo = false;
            }
            else checktitolo = true;

            if (autoreTextBox.Texts == "")
            {
                autoreTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkautore = false;
            }
            else checkautore = true;

            if (!decimal.TryParse(prezzoTextBox.Texts, out _))
            {
                prezzoTextBox.BackColor = Color.FromArgb(255, 159, 67);
                checkprezzo = false;
            }
            else checkprezzo = true;

            if (checktitolo && checkautore && checkprezzo)
            {
                Libro libro1 = new(titoloTextBox.Texts,
                                   autoreTextBox.Texts,
                                   Convert.ToDecimal(prezzoTextBox.Texts));
                libreria1.Add(libro1);
                dataGridView1.Rows.Add(libro1.Titolo, libro1.Autore, libro1.Prezzo);
            }
        }

        private void esciButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("sei sciuro di voler uscire?",
                                                  "Avviso",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning))
            {
                Application.Exit();
            }
        }

        private void autoremaxButton_Click(object sender, EventArgs e)
        {
            decimal max = 0;
            Libro libro1 = new("", "", 0);

            foreach (var item in libreria1)
            {
                if (item.Prezzo > max)
                {
                    max = item.Prezzo;
                    libro1 = item;
                }
            }

            MessageBox.Show("L'autore con il libro più costoso è " + libro1.Autore + " con il libro '" + libro1.Titolo + "'.\nIl suo prezzo è di €" + Convert.ToString(libro1.Prezzo),
                            "Risultato ricerca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void mediaprezziButton_Click(object sender, EventArgs e)
        {
            decimal somma = 0, media = 0;

            foreach (var item in libreria1)
            {
                somma += item.Prezzo;
            }
            media = somma / libreria1.Count;

            MessageBox.Show("La media dei prezzi è " + Convert.ToString(media),
                            "Risultato ricerca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void libroeconomicoButton_Click(object sender, EventArgs e)
        {
            decimal min = 1000;
            Libro libro1 = new("", "", 0);

            foreach (var item in libreria1)
            {
                if (item.Prezzo < min)
                {
                    min = item.Prezzo;
                    libro1 = item;
                }
            }

            MessageBox.Show("Il libro più economico è '" + libro1.Titolo + "', scritto da " + libro1.Autore +".\nIl suo prezzo è di €"+Convert.ToString(libro1.Prezzo),
                            "Risultato ricerca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        #endregion

        #region TextBox

        private void titoloTextBox__TextChanged(object sender, EventArgs e)
        {
            titoloTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        private void autoreTextBox__TextChanged(object sender, EventArgs e)
        {
            autoreTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        private void prezzoTextBox__TextChanged(object sender, EventArgs e)
        {
            prezzoTextBox.BackColor = Color.FromArgb(56, 79, 140);
        }

        #endregion
    }
}
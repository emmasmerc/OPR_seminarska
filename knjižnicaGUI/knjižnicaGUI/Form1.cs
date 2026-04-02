using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using knjižnicaLibrary;

namespace knjižnicaGUI
{
    public partial class knjižnica : Form
    {
        public knjižnica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        KnjižnicaSistem sistem = new KnjižnicaSistem();
        List<Član> člani = new List<Član>();


        private void btnDodajKnjigo_Click(object sender, EventArgs e)
        {

        }


        private void btnPrikaziClane_Click(object sender, EventArgs e)
        {
            listBoxClani.Items.Clear();

            for (int i = 0; i < člani.Count; i++)
            {
                listBoxClani.Items.Add(člani[i].ToString());
            }
        }

        private void btnIzposodi_Click(object sender, EventArgs e)
        {

        }

        static void IzpisDogodka(string msg)
        {
            MessageBox.Show(msg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajKnjigo_Click_1(object sender, EventArgs e)
        {
            var knjiga = new Knjiga(
                txtNaslov.Text,
                txtAvtor.Text,
                int.Parse(txtLeto.Text)
                );

            sistem.Dodaj(knjiga);

            listBoxGradiva.Items.Add(knjiga.ToString());
            MessageBox.Show("Knjiga dodana.");
        }

        private void btnDodajClana_Click_1(object sender, EventArgs e)
        {
            var clan = new Član(txtIme.Text);
            člani.Add(clan);

            listBoxClani.Items.Add(clan.ToString());

            MessageBox.Show("Član dodan.");
        }

        private void btnIzposodi_Click_1(object sender, EventArgs e)
        {
            int c = listBoxClani.SelectedIndex;
            int g = listBoxGradiva.SelectedIndex;

            if (c < 0 || g < 0)
            {
                MessageBox.Show("Izberi člana in gradivo!");
                return;
            }

            if (sistem[g] is IzposodljivoGradivo ig)
            {
                ig.ObIzposoji += IzpisDogodka;

                ig.ObIzposoji += (msg) =>
                {
                    člani[c].Zamudnina += ig.ZamudninaNaDan;
                };
            }

            if (sistem[g] is IIzposodljivo izposodljivo)
            {
                izposodljivo.Izposodi(člani[c]);
                MessageBox.Show("Gradivo izposojeno!");
            }

            listBoxClani.Items.Clear();

            for (int i = 0; i < člani.Count; i++)
            {
                listBoxClani.Items.Add(člani[i].ToString());
            }
        }

        private void btnDodajDVD_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto) || !int.TryParse(txtTrajanje.Text, out int trajanje))
            {
                MessageBox.Show("Napačen vnos!");
                return;
            }

            var dvd = new DVD(txtNaslov.Text, leto, trajanje);

            sistem.Dodaj(dvd);
            listBoxGradiva.Items.Add(dvd);

            MessageBox.Show("DVD dodan!");
        }

        private void btnDodajRevijo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto) || !int.TryParse(txtStevilka.Text, out int st))
            {
                MessageBox.Show("Napačen vnos!");
                return;
            }

            var revija = new Revija(txtNaslov.Text, leto, st);

            sistem.Dodaj(revija);
            listBoxGradiva.Items.Add(revija);

            MessageBox.Show("Revija dodana!");
        }

        private void btnDodajClanek_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto))
            {
                MessageBox.Show("Napačen vnos!");
                return;
            }

            var clanek = new Članek(txtNaslov.Text, leto, txtTema.Text);

            sistem.Dodaj(clanek);
            listBoxGradiva.Items.Add(clanek);

            MessageBox.Show("Članek dodan!");
        }
    }
}

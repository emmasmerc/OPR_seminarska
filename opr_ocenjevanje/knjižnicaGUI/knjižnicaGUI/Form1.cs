using knjižnicaLibrary;
namespace knjižnicaGUI
{
    public partial class Knjižnica : Form
    {
        KnjižnicaSistem sistem = new KnjižnicaSistem();
        List<Član> člani = new List<Član>();

        private void SkrijVse()
        {
            txtAvtor.Visible = false;
            txtTrajanje.Visible = false;
            txtStevilka.Visible = false;
            txtTema.Visible = false;

            lblAvtor.Visible = false;
            lblTrajanje.Visible = false;
            lblStevilka.Visible = false;
            lblTema.Visible = false;
        }

        public Knjižnica()
        {
            InitializeComponent();
        }

        private void btnDodajKnjigo_Click(object sender, EventArgs e)
        {
            var knjiga = new Knjiga(
                txtNaslov.Text,
                txtAvtor.Text,
                int.Parse(txtLeto.Text)
            );

            sistem.Dodaj(knjiga);

            listBoxGradiva.Items.Add(knjiga.ToString());

            MessageBox.Show("Knjiga dodana");
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            var clan = new Član(txtIme.Text);
            člani.Add(clan);

            listBoxClani.Items.Add(clan.ToString());

            MessageBox.Show("Član dodan");

            listBoxClani.Items.Clear();

            for (int i = 0; i < člani.Count; i++)
            {
                listBoxClani.Items.Add(člani[i].ToString());
            }
        }

        private void btnIzposodiGradivo_Click(object sender, EventArgs e)
        {
            int c = listBoxClani.SelectedIndex;
            int g = listBoxGradiva.SelectedIndex;

            if (c < 0 || g < 0)
            {
                MessageBox.Show("Izberi člana in gradivo");
                return;
            }

            if (sistem[g] is IzposodljivoGradivo ig)
            {
                ig.ObIzposoji += IzpisDogodka;
            }

            if (sistem[g] is IIzposodljivo izposodljivo)
            {
                izposodljivo.Izposodi(člani[c]);
                MessageBox.Show("Gradivo izposojeno");
            }

            static void IzpisDogodka(string msg)
            {
                MessageBox.Show(" " + msg);
            }
        }

        private void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkrijVse();

            switch (cmbVrsta.SelectedItem.ToString())
            {
                case "Knjiga":
                    txtAvtor.Visible = true;
                    break;

                case "DVD":
                    txtAvtor.Visible = true;
                    txtTrajanje.Visible = true;
                    break;

                case "Revija":
                    txtAvtor.Visible = true;
                    txtStevilka.Visible = true;
                    break;

                case "Članek":
                    txtAvtor.Visible = true;
                    txtTema.Visible = true;
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto))
            {
                MessageBox.Show("Napaka pri letu!");
                return;
            }

            var vrsta = cmbVrsta.SelectedItem.ToString();

            Gradivo g = null;

            switch (vrsta)
            {
                case "Knjiga":
                    g = new Knjiga(txtNaslov.Text, txtAvtor.Text, leto);
                    break;

                case "DVD":
                    if (!int.TryParse(txtTrajanje.Text, out int trajanje))
                        return;

                    g = new DVD(txtNaslov.Text, leto, trajanje);
                    break;

                case "Revija":
                    if (!int.TryParse(txtStevilka.Text, out int st))
                        return;

                    g = new Revija(txtNaslov.Text, leto, st);
                    break;

                case "Članek":
                    g = new Članek(txtNaslov.Text, leto, txtTema.Text);
                    break;
            }

            sistem.Dodaj(g);
            listBoxGradiva.Items.Add(g);
        }

        private void btnDodajDVD_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto) || !int.TryParse(txtTrajanje.Text, out int trajanje))
            {
                MessageBox.Show("Napačen vnos");
                return;
            }

            var dvd = new DVD(txtNaslov.Text, leto, trajanje);

            sistem.Dodaj(dvd);
            listBoxGradiva.Items.Add(dvd);

            MessageBox.Show("DVD dodan");
        }

        private void btnDodajRevijo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto) || !int.TryParse(txtStevilka.Text, out int st))
            {
                MessageBox.Show("Napačen vnos");
                return;
            }

            var revija = new Revija(txtNaslov.Text, leto, st);

            sistem.Dodaj(revija);
            listBoxGradiva.Items.Add(revija);

            MessageBox.Show("Revija dodana");
        }

        private void btnDodajClanek_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLeto.Text, out int leto) || !int.TryParse(txtStevilka.Text, out int st))
            {
                MessageBox.Show("Napačen vnos");
                return;
            }

            var revija = new Revija(txtNaslov.Text, leto, st);

            sistem.Dodaj(revija);
            listBoxGradiva.Items.Add(revija);

            MessageBox.Show("Revija dodana");
        }
    }
}

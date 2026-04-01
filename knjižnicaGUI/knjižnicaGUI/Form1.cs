using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KnjižnicaMainLibrary;

namespace knjižnicaGUI
{
    public partial class Knjižnica : Form
    {
        KnjižnicaSistem sistem = new KnjižnicaSistem();
        List<Član> člani = new List<Član>();


        public Knjižnica()
        {
            InitializeComponent();
        }

        private void btnDodajKnjigo_Click(object sender, EventArgs e)
        {
            sistem.Dodaj(new Knjiga(
                txtNaslov.Text,
                txtAvtor.Text,
                int.Parse(txtLeto.Text)
            ));

            MessageBox.Show("Knjiga dodana!");
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            člani.Add(new Član(txtIme.Text));
            MessageBox.Show("Član dodan!");
        }

        private void btnPrikaziGradiva_Click(object sender, EventArgs e)
        {
            listBoxGradiva.Items.Clear();

            for (int i = 0; i < sistem.Število; i++)
            {
                listBoxGradiva.Items.Add(sistem[i].ToString());
            }
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
            }

            if (sistem[g] is IIzposodljivo izposodljivo)
            {
                izposodljivo.Izposodi(člani[c]);
                MessageBox.Show("Gradivo izposojeno!");
            }
        }

        static void IzpisDogodka(string msg)
        {
            MessageBox.Show("DOGODEK: " + msg);
        }
    }
}

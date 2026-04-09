namespace knjižnicaGUI
{
    partial class Knjižnica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNaslov = new TextBox();
            txtAvtor = new TextBox();
            txtLeto = new TextBox();
            txtIme = new TextBox();
            btnDodajKnjigo = new Button();
            btnIzposodiGradivo = new Button();
            btnDodajClana = new Button();
            lblAvtor = new Label();
            lblNaslov = new Label();
            lblLeto = new Label();
            lblIme = new Label();
            listBoxClani = new ListBox();
            listBoxGradiva = new ListBox();
            txtTrajanje = new TextBox();
            txtStevilka = new TextBox();
            txtTema = new TextBox();
            btnDodajDVD = new Button();
            btnDodajRevijo = new Button();
            btnDodajClanek = new Button();
            lblTrajanje = new Label();
            lblStevilka = new Label();
            lblTema = new Label();
            cmbVrsta = new ComboBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(46, 37);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(100, 23);
            txtNaslov.TabIndex = 0;
            // 
            // txtAvtor
            // 
            txtAvtor.Location = new Point(46, 103);
            txtAvtor.Name = "txtAvtor";
            txtAvtor.Size = new Size(100, 23);
            txtAvtor.TabIndex = 1;
            // 
            // txtLeto
            // 
            txtLeto.Location = new Point(46, 174);
            txtLeto.Name = "txtLeto";
            txtLeto.Size = new Size(100, 23);
            txtLeto.TabIndex = 2;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(511, 366);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(100, 23);
            txtIme.TabIndex = 13;
            // 
            // btnDodajKnjigo
            // 
            btnDodajKnjigo.Location = new Point(190, 102);
            btnDodajKnjigo.Name = "btnDodajKnjigo";
            btnDodajKnjigo.Size = new Size(85, 23);
            btnDodajKnjigo.TabIndex = 3;
            btnDodajKnjigo.Text = "Dodaj knjigo";
            btnDodajKnjigo.UseVisualStyleBackColor = true;
            btnDodajKnjigo.Click += btnDodajKnjigo_Click;
            // 
            // btnIzposodiGradivo
            // 
            btnIzposodiGradivo.Location = new Point(616, 40);
            btnIzposodiGradivo.Name = "btnIzposodiGradivo";
            btnIzposodiGradivo.Size = new Size(120, 23);
            btnIzposodiGradivo.TabIndex = 12;
            btnIzposodiGradivo.Text = "Izposodi gradivo";
            btnIzposodiGradivo.UseVisualStyleBackColor = true;
            btnIzposodiGradivo.Click += btnIzposodiGradivo_Click;
            // 
            // btnDodajClana
            // 
            btnDodajClana.Location = new Point(661, 366);
            btnDodajClana.Name = "btnDodajClana";
            btnDodajClana.Size = new Size(85, 23);
            btnDodajClana.TabIndex = 14;
            btnDodajClana.Text = "Dodaj člana";
            btnDodajClana.UseVisualStyleBackColor = true;
            btnDodajClana.Click += btnDodajClana_Click;
            // 
            // lblAvtor
            // 
            lblAvtor.AutoSize = true;
            lblAvtor.Location = new Point(62, 85);
            lblAvtor.Name = "lblAvtor";
            lblAvtor.Size = new Size(74, 15);
            lblAvtor.TabIndex = 16;
            lblAvtor.Text = "Vpiši avtorja:";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(62, 19);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(72, 15);
            lblNaslov.TabIndex = 15;
            lblNaslov.Text = "Vpiši naslov:";
            // 
            // lblLeto
            // 
            lblLeto.AutoSize = true;
            lblLeto.Location = new Point(62, 156);
            lblLeto.Name = "lblLeto";
            lblLeto.Size = new Size(58, 15);
            lblLeto.TabIndex = 17;
            lblLeto.Text = "Vpiši leto:";
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(530, 348);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(58, 15);
            lblIme.TabIndex = 21;
            lblIme.Text = "Vpiši ime:";
            // 
            // listBoxClani
            // 
            listBoxClani.FormattingEnabled = true;
            listBoxClani.ItemHeight = 15;
            listBoxClani.Location = new Point(411, 69);
            listBoxClani.Name = "listBoxClani";
            listBoxClani.Size = new Size(155, 94);
            listBoxClani.TabIndex = 10;
            // 
            // listBoxGradiva
            // 
            listBoxGradiva.FormattingEnabled = true;
            listBoxGradiva.ItemHeight = 15;
            listBoxGradiva.Location = new Point(596, 69);
            listBoxGradiva.Name = "listBoxGradiva";
            listBoxGradiva.Size = new Size(150, 94);
            listBoxGradiva.TabIndex = 11;
            // 
            // txtTrajanje
            // 
            txtTrajanje.Location = new Point(46, 227);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(100, 23);
            txtTrajanje.TabIndex = 4;
            // 
            // txtStevilka
            // 
            txtStevilka.Location = new Point(46, 283);
            txtStevilka.Name = "txtStevilka";
            txtStevilka.Size = new Size(100, 23);
            txtStevilka.TabIndex = 6;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(46, 340);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(100, 23);
            txtTema.TabIndex = 8;
            // 
            // btnDodajDVD
            // 
            btnDodajDVD.Location = new Point(190, 226);
            btnDodajDVD.Name = "btnDodajDVD";
            btnDodajDVD.Size = new Size(85, 23);
            btnDodajDVD.TabIndex = 5;
            btnDodajDVD.Text = "Dodaj DVD";
            btnDodajDVD.UseVisualStyleBackColor = true;
            btnDodajDVD.Click += btnDodajDVD_Click;
            // 
            // btnDodajRevijo
            // 
            btnDodajRevijo.Location = new Point(190, 283);
            btnDodajRevijo.Name = "btnDodajRevijo";
            btnDodajRevijo.Size = new Size(85, 23);
            btnDodajRevijo.TabIndex = 7;
            btnDodajRevijo.Text = "Dodaj revijo";
            btnDodajRevijo.UseVisualStyleBackColor = true;
            btnDodajRevijo.Click += btnDodajRevijo_Click;
            // 
            // btnDodajClanek
            // 
            btnDodajClanek.Location = new Point(190, 340);
            btnDodajClanek.Name = "btnDodajClanek";
            btnDodajClanek.Size = new Size(85, 23);
            btnDodajClanek.TabIndex = 9;
            btnDodajClanek.Text = "Dodaj članek";
            btnDodajClanek.UseVisualStyleBackColor = true;
            btnDodajClanek.Click += btnDodajClanek_Click;
            // 
            // lblTrajanje
            // 
            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(62, 209);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(77, 15);
            lblTrajanje.TabIndex = 18;
            lblTrajanje.Text = "Vpiši trajanje:";
            // 
            // lblStevilka
            // 
            lblStevilka.AutoSize = true;
            lblStevilka.Location = new Point(62, 265);
            lblStevilka.Name = "lblStevilka";
            lblStevilka.Size = new Size(78, 15);
            lblStevilka.TabIndex = 19;
            lblStevilka.Text = "Vpiši številko:";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(62, 322);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(66, 15);
            lblTema.TabIndex = 20;
            lblTema.Text = "Vpiši temo:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Knjiga", "DVD", "Revija", "Članek" });
            cmbVrsta.Location = new Point(411, 206);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(121, 23);
            cmbVrsta.TabIndex = 23;
            cmbVrsta.SelectedIndexChanged += cmbVrsta_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(561, 206);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 22;
            btnDodaj.Text = "Dodaj gradivo";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // Knjižnica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrsta);
            Controls.Add(lblTema);
            Controls.Add(lblStevilka);
            Controls.Add(lblTrajanje);
            Controls.Add(btnDodajClanek);
            Controls.Add(btnDodajRevijo);
            Controls.Add(btnDodajDVD);
            Controls.Add(txtTema);
            Controls.Add(txtStevilka);
            Controls.Add(txtTrajanje);
            Controls.Add(listBoxGradiva);
            Controls.Add(listBoxClani);
            Controls.Add(lblIme);
            Controls.Add(lblLeto);
            Controls.Add(lblNaslov);
            Controls.Add(lblAvtor);
            Controls.Add(btnDodajClana);
            Controls.Add(btnIzposodiGradivo);
            Controls.Add(btnDodajKnjigo);
            Controls.Add(txtIme);
            Controls.Add(txtLeto);
            Controls.Add(txtAvtor);
            Controls.Add(txtNaslov);
            Name = "Knjižnica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaslov;
        private TextBox txtAvtor;
        private TextBox txtLeto;
        private TextBox txtIme;
        private Button btnDodajKnjigo;
        private Button btnIzposodiGradivo;
        private Button btnDodajClana;
        private Label lblAvtor;
        private Label lblNaslov;
        private Label lblLeto;
        private Label lblIme;
        private ListBox listBoxClani;
        private ListBox listBoxGradiva;
        private TextBox txtTrajanje;
        private TextBox txtStevilka;
        private TextBox txtTema;
        private Button btnDodajDVD;
        private Button btnDodajRevijo;
        private Button btnDodajClanek;
        private Label lblTrajanje;
        private Label lblStevilka;
        private Label lblTema;
        private ComboBox cmbVrsta;
        private Button btnDodaj;
    }
}

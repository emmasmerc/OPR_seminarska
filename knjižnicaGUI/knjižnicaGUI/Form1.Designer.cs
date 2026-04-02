namespace knjižnicaGUI
{
    partial class knjižnica
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
            btnDodajKnjigo = new Button();
            btnDodajClana = new Button();
            btnIzposodi = new Button();
            listBoxGradiva = new ListBox();
            listBoxClani = new ListBox();
            txtNaslov = new TextBox();
            txtAvtor = new TextBox();
            txtLeto = new TextBox();
            txtIme = new TextBox();
            lblVpisiNaslov = new Label();
            lblVpisiAvtor = new Label();
            lblVpisiLeto = new Label();
            lblVpisiIme = new Label();
            txtTrajanje = new TextBox();
            txtStevilka = new TextBox();
            txtTema = new TextBox();
            btnDodajDVD = new Button();
            btnDodajRevijo = new Button();
            btnDodajClanek = new Button();
            lblVpišiTrajanje = new Label();
            lblVpisiStevilko = new Label();
            lblVpisiTemo = new Label();
            SuspendLayout();
            // 
            // btnDodajKnjigo
            // 
            btnDodajKnjigo.Location = new Point(210, 121);
            btnDodajKnjigo.Name = "btnDodajKnjigo";
            btnDodajKnjigo.Size = new Size(114, 23);
            btnDodajKnjigo.TabIndex = 3;
            btnDodajKnjigo.Text = "Dodaj knjigo";
            btnDodajKnjigo.UseVisualStyleBackColor = true;
            btnDodajKnjigo.Click += btnDodajKnjigo_Click_1;
            // 
            // btnDodajClana
            // 
            btnDodajClana.Location = new Point(644, 285);
            btnDodajClana.Name = "btnDodajClana";
            btnDodajClana.Size = new Size(114, 23);
            btnDodajClana.TabIndex = 5;
            btnDodajClana.Text = "Dodaj člana";
            btnDodajClana.UseVisualStyleBackColor = true;
            btnDodajClana.Click += btnDodajClana_Click_1;
            // 
            // btnIzposodi
            // 
            btnIzposodi.Location = new Point(644, 47);
            btnIzposodi.Name = "btnIzposodi";
            btnIzposodi.Size = new Size(102, 23);
            btnIzposodi.TabIndex = 6;
            btnIzposodi.Text = "Izposodi gradivo";
            btnIzposodi.UseVisualStyleBackColor = true;
            btnIzposodi.Click += btnIzposodi_Click_1;
            // 
            // listBoxGradiva
            // 
            listBoxGradiva.FormattingEnabled = true;
            listBoxGradiva.ItemHeight = 15;
            listBoxGradiva.Location = new Point(527, 89);
            listBoxGradiva.Name = "listBoxGradiva";
            listBoxGradiva.Size = new Size(219, 139);
            listBoxGradiva.TabIndex = 9;
            // 
            // listBoxClani
            // 
            listBoxClani.FormattingEnabled = true;
            listBoxClani.ItemHeight = 15;
            listBoxClani.Location = new Point(527, 319);
            listBoxClani.Name = "listBoxClani";
            listBoxClani.Size = new Size(231, 109);
            listBoxClani.TabIndex = 8;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(69, 69);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(107, 23);
            txtNaslov.TabIndex = 0;
            // 
            // txtAvtor
            // 
            txtAvtor.Location = new Point(69, 122);
            txtAvtor.Name = "txtAvtor";
            txtAvtor.Size = new Size(107, 23);
            txtAvtor.TabIndex = 1;
            // 
            // txtLeto
            // 
            txtLeto.Location = new Point(69, 180);
            txtLeto.Name = "txtLeto";
            txtLeto.Size = new Size(107, 23);
            txtLeto.TabIndex = 2;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(527, 285);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(107, 23);
            txtIme.TabIndex = 4;
            // 
            // lblVpisiNaslov
            // 
            lblVpisiNaslov.AutoSize = true;
            lblVpisiNaslov.Location = new Point(82, 51);
            lblVpisiNaslov.Name = "lblVpisiNaslov";
            lblVpisiNaslov.Size = new Size(72, 15);
            lblVpisiNaslov.TabIndex = 11;
            lblVpisiNaslov.Text = "Vpiši naslov:";
            lblVpisiNaslov.Click += label1_Click;
            // 
            // lblVpisiAvtor
            // 
            lblVpisiAvtor.AutoSize = true;
            lblVpisiAvtor.Location = new Point(80, 104);
            lblVpisiAvtor.Name = "lblVpisiAvtor";
            lblVpisiAvtor.Size = new Size(74, 15);
            lblVpisiAvtor.TabIndex = 12;
            lblVpisiAvtor.Text = "Vpiši avtorja:";
            // 
            // lblVpisiLeto
            // 
            lblVpisiLeto.AutoSize = true;
            lblVpisiLeto.Location = new Point(80, 162);
            lblVpisiLeto.Name = "lblVpisiLeto";
            lblVpisiLeto.Size = new Size(91, 15);
            lblVpisiLeto.TabIndex = 13;
            lblVpisiLeto.Text = "Vpiši leto izdaje:";
            // 
            // lblVpisiIme
            // 
            lblVpisiIme.AutoSize = true;
            lblVpisiIme.Location = new Point(549, 267);
            lblVpisiIme.Name = "lblVpisiIme";
            lblVpisiIme.Size = new Size(58, 15);
            lblVpisiIme.TabIndex = 14;
            lblVpisiIme.Text = "Vpiši ime:";
            // 
            // txtTrajanje
            // 
            txtTrajanje.Location = new Point(69, 231);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(107, 23);
            txtTrajanje.TabIndex = 15;
            // 
            // txtStevilka
            // 
            txtStevilka.Location = new Point(69, 285);
            txtStevilka.Name = "txtStevilka";
            txtStevilka.Size = new Size(107, 23);
            txtStevilka.TabIndex = 16;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(69, 337);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(107, 23);
            txtTema.TabIndex = 17;
            // 
            // btnDodajDVD
            // 
            btnDodajDVD.Location = new Point(210, 239);
            btnDodajDVD.Name = "btnDodajDVD";
            btnDodajDVD.Size = new Size(114, 23);
            btnDodajDVD.TabIndex = 18;
            btnDodajDVD.Text = "Dodaj DVD";
            btnDodajDVD.UseVisualStyleBackColor = true;
            btnDodajDVD.Click += btnDodajDVD_Click;
            // 
            // btnDodajRevijo
            // 
            btnDodajRevijo.Location = new Point(210, 293);
            btnDodajRevijo.Name = "btnDodajRevijo";
            btnDodajRevijo.Size = new Size(114, 23);
            btnDodajRevijo.TabIndex = 19;
            btnDodajRevijo.Text = "Dodaj revijo";
            btnDodajRevijo.UseVisualStyleBackColor = true;
            btnDodajRevijo.Click += btnDodajRevijo_Click;
            // 
            // btnDodajClanek
            // 
            btnDodajClanek.Location = new Point(210, 336);
            btnDodajClanek.Name = "btnDodajClanek";
            btnDodajClanek.Size = new Size(114, 23);
            btnDodajClanek.TabIndex = 20;
            btnDodajClanek.Text = "Dodaj članek";
            btnDodajClanek.UseVisualStyleBackColor = true;
            btnDodajClanek.Click += btnDodajClanek_Click;
            // 
            // lblVpišiTrajanje
            // 
            lblVpišiTrajanje.AutoSize = true;
            lblVpišiTrajanje.Location = new Point(69, 213);
            lblVpišiTrajanje.Name = "lblVpišiTrajanje";
            lblVpišiTrajanje.Size = new Size(110, 15);
            lblVpišiTrajanje.TabIndex = 21;
            lblVpišiTrajanje.Text = "Vpiši čas dogajanja:";
            // 
            // lblVpisiStevilko
            // 
            lblVpisiStevilko.AutoSize = true;
            lblVpisiStevilko.Location = new Point(69, 267);
            lblVpisiStevilko.Name = "lblVpisiStevilko";
            lblVpisiStevilko.Size = new Size(109, 15);
            lblVpisiStevilko.TabIndex = 22;
            lblVpisiStevilko.Text = "Vpiši številko revije:";
            // 
            // lblVpisiTemo
            // 
            lblVpisiTemo.AutoSize = true;
            lblVpisiTemo.Location = new Point(69, 319);
            lblVpisiTemo.Name = "lblVpisiTemo";
            lblVpisiTemo.Size = new Size(103, 15);
            lblVpisiTemo.TabIndex = 23;
            lblVpisiTemo.Text = "Vpiši temo članka:";
            // 
            // knjižnica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVpisiTemo);
            Controls.Add(lblVpisiStevilko);
            Controls.Add(lblVpišiTrajanje);
            Controls.Add(btnDodajClanek);
            Controls.Add(btnDodajRevijo);
            Controls.Add(btnDodajDVD);
            Controls.Add(txtTema);
            Controls.Add(txtStevilka);
            Controls.Add(txtTrajanje);
            Controls.Add(lblVpisiIme);
            Controls.Add(lblVpisiLeto);
            Controls.Add(lblVpisiAvtor);
            Controls.Add(lblVpisiNaslov);
            Controls.Add(txtIme);
            Controls.Add(txtLeto);
            Controls.Add(txtAvtor);
            Controls.Add(txtNaslov);
            Controls.Add(listBoxClani);
            Controls.Add(listBoxGradiva);
            Controls.Add(btnIzposodi);
            Controls.Add(btnDodajClana);
            Controls.Add(btnDodajKnjigo);
            Name = "knjižnica";
            Text = "Knjižnica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajKnjigo;
        private Button btnDodajClana;
        private Button btnIzposodi;
        private ListBox listBoxGradiva;
        private ListBox listBoxClani;
        private TextBox txtNaslov;
        private TextBox txtAvtor;
        private TextBox txtLeto;
        private TextBox txtIme;
        private Label lblVpisiNaslov;
        private Label lblVpisiAvtor;
        private Label lblVpisiLeto;
        private Label lblVpisiIme;
        private TextBox txtTrajanje;
        private TextBox txtStevilka;
        private TextBox txtTema;
        private Button btnDodajDVD;
        private Button btnDodajRevijo;
        private Button btnDodajClanek;
        private Label lblVpišiTrajanje;
        private Label lblVpisiStevilko;
        private Label lblVpisiTemo;
    }
}

namespace knjižnicaGUI
{
    partial class Knjižnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAvtor = new System.Windows.Forms.TextBox();
            this.txtLeto = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.listBoxGradiva = new System.Windows.Forms.ListBox();
            this.listBoxClani = new System.Windows.Forms.ListBox();
            this.btnDodajKnjigo = new System.Windows.Forms.Button();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.btnPrikaziGradiva = new System.Windows.Forms.Button();
            this.btnPrikaziClane = new System.Windows.Forms.Button();
            this.btnIzposodi = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelAvtor = new System.Windows.Forms.Label();
            this.labelLeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(12, 28);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(100, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // txtAvtor
            // 
            this.txtAvtor.Location = new System.Drawing.Point(12, 70);
            this.txtAvtor.Name = "txtAvtor";
            this.txtAvtor.Size = new System.Drawing.Size(100, 20);
            this.txtAvtor.TabIndex = 1;
            // 
            // txtLeto
            // 
            this.txtLeto.Location = new System.Drawing.Point(12, 113);
            this.txtLeto.Name = "txtLeto";
            this.txtLeto.Size = new System.Drawing.Size(100, 20);
            this.txtLeto.TabIndex = 2;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 184);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // listBoxGradiva
            // 
            this.listBoxGradiva.FormattingEnabled = true;
            this.listBoxGradiva.Location = new System.Drawing.Point(353, 70);
            this.listBoxGradiva.Name = "listBoxGradiva";
            this.listBoxGradiva.Size = new System.Drawing.Size(218, 173);
            this.listBoxGradiva.TabIndex = 4;
            // 
            // listBoxClani
            // 
            this.listBoxClani.FormattingEnabled = true;
            this.listBoxClani.Location = new System.Drawing.Point(577, 70);
            this.listBoxClani.Name = "listBoxClani";
            this.listBoxClani.Size = new System.Drawing.Size(184, 173);
            this.listBoxClani.TabIndex = 5;
            // 
            // btnDodajKnjigo
            // 
            this.btnDodajKnjigo.Location = new System.Drawing.Point(140, 70);
            this.btnDodajKnjigo.Name = "btnDodajKnjigo";
            this.btnDodajKnjigo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKnjigo.TabIndex = 6;
            this.btnDodajKnjigo.Text = "Dodaj knjigo";
            this.btnDodajKnjigo.UseVisualStyleBackColor = true;
            this.btnDodajKnjigo.Click += new System.EventHandler(this.btnDodajKnjigo_Click);
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(140, 184);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(75, 23);
            this.btnDodajClana.TabIndex = 7;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziGradiva
            // 
            this.btnPrikaziGradiva.Location = new System.Drawing.Point(353, 36);
            this.btnPrikaziGradiva.Name = "btnPrikaziGradiva";
            this.btnPrikaziGradiva.Size = new System.Drawing.Size(105, 23);
            this.btnPrikaziGradiva.TabIndex = 8;
            this.btnPrikaziGradiva.Text = "Prikaži gradiva";
            this.btnPrikaziGradiva.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziClane
            // 
            this.btnPrikaziClane.Location = new System.Drawing.Point(634, 36);
            this.btnPrikaziClane.Name = "btnPrikaziClane";
            this.btnPrikaziClane.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziClane.TabIndex = 9;
            this.btnPrikaziClane.Text = "Prikaži člane";
            this.btnPrikaziClane.UseVisualStyleBackColor = true;
            // 
            // btnIzposodi
            // 
            this.btnIzposodi.Location = new System.Drawing.Point(475, 36);
            this.btnIzposodi.Name = "btnIzposodi";
            this.btnIzposodi.Size = new System.Drawing.Size(96, 23);
            this.btnIzposodi.TabIndex = 10;
            this.btnIzposodi.Text = "Izposodi gradivo";
            this.btnIzposodi.UseVisualStyleBackColor = true;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(21, 168);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(80, 13);
            this.labelIme.TabIndex = 11;
            this.labelIme.Text = "Vpiši ime člana:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(15, 12);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(97, 13);
            this.labelNaslov.TabIndex = 12;
            this.labelNaslov.Text = "Vpiši naslov knjige:";
            // 
            // labelAvtor
            // 
            this.labelAvtor.AutoSize = true;
            this.labelAvtor.Location = new System.Drawing.Point(15, 54);
            this.labelAvtor.Name = "labelAvtor";
            this.labelAvtor.Size = new System.Drawing.Size(86, 13);
            this.labelAvtor.TabIndex = 13;
            this.labelAvtor.Text = "Vpiši ime avtorja:";
            // 
            // labelLeto
            // 
            this.labelLeto.AutoSize = true;
            this.labelLeto.Location = new System.Drawing.Point(15, 97);
            this.labelLeto.Name = "labelLeto";
            this.labelLeto.Size = new System.Drawing.Size(83, 13);
            this.labelLeto.TabIndex = 14;
            this.labelLeto.Text = "Vpiši leto knjige:";
            // 
            // Knjižnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLeto);
            this.Controls.Add(this.labelAvtor);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.btnIzposodi);
            this.Controls.Add(this.btnPrikaziClane);
            this.Controls.Add(this.btnPrikaziGradiva);
            this.Controls.Add(this.btnDodajClana);
            this.Controls.Add(this.btnDodajKnjigo);
            this.Controls.Add(this.listBoxClani);
            this.Controls.Add(this.listBoxGradiva);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtLeto);
            this.Controls.Add(this.txtAvtor);
            this.Controls.Add(this.txtNaslov);
            this.Name = "Knjižnica";
            this.Text = "Knjižnica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAvtor;
        private System.Windows.Forms.TextBox txtLeto;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ListBox listBoxGradiva;
        private System.Windows.Forms.ListBox listBoxClani;
        private System.Windows.Forms.Button btnDodajKnjigo;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Button btnPrikaziGradiva;
        private System.Windows.Forms.Button btnPrikaziClane;
        private System.Windows.Forms.Button btnIzposodi;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelAvtor;
        private System.Windows.Forms.Label labelLeto;
    }
}


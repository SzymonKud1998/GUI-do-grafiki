
namespace GUI
{
    partial class Photoshop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_suma = new System.Windows.Forms.Button();
            this.button_odejmowanie = new System.Windows.Forms.Button();
            this.button_różnica = new System.Windows.Forms.Button();
            this.button_mnozenie = new System.Windows.Forms.Button();
            this.button_mn_odw = new System.Windows.Forms.Button();
            this.button_negacja = new System.Windows.Forms.Button();
            this.button_ciemniejsze = new System.Windows.Forms.Button();
            this.button_jasniejsze = new System.Windows.Forms.Button();
            this.button_wylaczenie = new System.Windows.Forms.Button();
            this.button_nakladka = new System.Windows.Forms.Button();
            this.button_ost_sw = new System.Windows.Forms.Button();
            this.button_lag_sw = new System.Windows.Forms.Button();
            this.button_rozcienczenie = new System.Windows.Forms.Button();
            this.button_wypalanie = new System.Windows.Forms.Button();
            this.button_reflect = new System.Windows.Forms.Button();
            this.button_przezroczystosc = new System.Windows.Forms.Button();
            this.pictureBox_zdj_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_zdj_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_wynik = new System.Windows.Forms.PictureBox();
            this.numericUpDown_przezroczystoc = new System.Windows.Forms.NumericUpDown();
            this.Czyszczenie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_negatyw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_jasnosc = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_przezroczystoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_jasnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // button_suma
            // 
            this.button_suma.Location = new System.Drawing.Point(13, 13);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(126, 23);
            this.button_suma.TabIndex = 0;
            this.button_suma.Text = "Suma";
            this.button_suma.UseVisualStyleBackColor = true;
            this.button_suma.Click += new System.EventHandler(this.suma_click);
            // 
            // button_odejmowanie
            // 
            this.button_odejmowanie.Location = new System.Drawing.Point(13, 43);
            this.button_odejmowanie.Name = "button_odejmowanie";
            this.button_odejmowanie.Size = new System.Drawing.Size(126, 23);
            this.button_odejmowanie.TabIndex = 1;
            this.button_odejmowanie.Text = "Odejmowanie";
            this.button_odejmowanie.UseVisualStyleBackColor = true;
            // 
            // button_różnica
            // 
            this.button_różnica.Location = new System.Drawing.Point(13, 73);
            this.button_różnica.Name = "button_różnica";
            this.button_różnica.Size = new System.Drawing.Size(126, 23);
            this.button_różnica.TabIndex = 2;
            this.button_różnica.Text = "Różnica";
            this.button_różnica.UseVisualStyleBackColor = true;
            this.button_różnica.Click += new System.EventHandler(this.roznica_click);
            // 
            // button_mnozenie
            // 
            this.button_mnozenie.Location = new System.Drawing.Point(13, 103);
            this.button_mnozenie.Name = "button_mnozenie";
            this.button_mnozenie.Size = new System.Drawing.Size(126, 23);
            this.button_mnozenie.TabIndex = 3;
            this.button_mnozenie.Text = "Mnożenie";
            this.button_mnozenie.UseVisualStyleBackColor = true;
            this.button_mnozenie.Click += new System.EventHandler(this.mnozenie_click);
            // 
            // button_mn_odw
            // 
            this.button_mn_odw.Location = new System.Drawing.Point(13, 133);
            this.button_mn_odw.Name = "button_mn_odw";
            this.button_mn_odw.Size = new System.Drawing.Size(126, 23);
            this.button_mn_odw.TabIndex = 4;
            this.button_mn_odw.Text = "Mnożenie Odwrotności";
            this.button_mn_odw.UseVisualStyleBackColor = true;
            this.button_mn_odw.Click += new System.EventHandler(this.mn_odw_click);
            // 
            // button_negacja
            // 
            this.button_negacja.Location = new System.Drawing.Point(13, 163);
            this.button_negacja.Name = "button_negacja";
            this.button_negacja.Size = new System.Drawing.Size(126, 23);
            this.button_negacja.TabIndex = 5;
            this.button_negacja.Text = "Negacja";
            this.button_negacja.UseVisualStyleBackColor = true;
            this.button_negacja.Click += new System.EventHandler(this.negacja_click);
            // 
            // button_ciemniejsze
            // 
            this.button_ciemniejsze.Location = new System.Drawing.Point(13, 193);
            this.button_ciemniejsze.Name = "button_ciemniejsze";
            this.button_ciemniejsze.Size = new System.Drawing.Size(126, 23);
            this.button_ciemniejsze.TabIndex = 6;
            this.button_ciemniejsze.Text = "Ciemniejsze";
            this.button_ciemniejsze.UseVisualStyleBackColor = true;
            this.button_ciemniejsze.Click += new System.EventHandler(this.ciemniejsze_click);
            // 
            // button_jasniejsze
            // 
            this.button_jasniejsze.Location = new System.Drawing.Point(13, 223);
            this.button_jasniejsze.Name = "button_jasniejsze";
            this.button_jasniejsze.Size = new System.Drawing.Size(126, 23);
            this.button_jasniejsze.TabIndex = 7;
            this.button_jasniejsze.Text = "Jaśniejsze";
            this.button_jasniejsze.UseVisualStyleBackColor = true;
            this.button_jasniejsze.Click += new System.EventHandler(this.jasniejsze_click);
            // 
            // button_wylaczenie
            // 
            this.button_wylaczenie.Location = new System.Drawing.Point(13, 254);
            this.button_wylaczenie.Name = "button_wylaczenie";
            this.button_wylaczenie.Size = new System.Drawing.Size(126, 23);
            this.button_wylaczenie.TabIndex = 8;
            this.button_wylaczenie.Text = "Wyłączenie";
            this.button_wylaczenie.UseVisualStyleBackColor = true;
            this.button_wylaczenie.Click += new System.EventHandler(this.wyl_click);
            // 
            // button_nakladka
            // 
            this.button_nakladka.Location = new System.Drawing.Point(13, 283);
            this.button_nakladka.Name = "button_nakladka";
            this.button_nakladka.Size = new System.Drawing.Size(126, 23);
            this.button_nakladka.TabIndex = 9;
            this.button_nakladka.Text = "Nakładka";
            this.button_nakladka.UseVisualStyleBackColor = true;
            this.button_nakladka.Click += new System.EventHandler(this.nakladka_click);
            // 
            // button_ost_sw
            // 
            this.button_ost_sw.Location = new System.Drawing.Point(13, 314);
            this.button_ost_sw.Name = "button_ost_sw";
            this.button_ost_sw.Size = new System.Drawing.Size(126, 23);
            this.button_ost_sw.TabIndex = 10;
            this.button_ost_sw.Text = "Ostre światło";
            this.button_ost_sw.UseVisualStyleBackColor = true;
            this.button_ost_sw.Click += new System.EventHandler(this.ostre_click);
            // 
            // button_lag_sw
            // 
            this.button_lag_sw.Location = new System.Drawing.Point(13, 343);
            this.button_lag_sw.Name = "button_lag_sw";
            this.button_lag_sw.Size = new System.Drawing.Size(126, 23);
            this.button_lag_sw.TabIndex = 11;
            this.button_lag_sw.Text = "Łagodne światło";
            this.button_lag_sw.UseVisualStyleBackColor = true;
            this.button_lag_sw.Click += new System.EventHandler(this.lagodne_click);
            // 
            // button_rozcienczenie
            // 
            this.button_rozcienczenie.Location = new System.Drawing.Point(13, 373);
            this.button_rozcienczenie.Name = "button_rozcienczenie";
            this.button_rozcienczenie.Size = new System.Drawing.Size(126, 23);
            this.button_rozcienczenie.TabIndex = 12;
            this.button_rozcienczenie.Text = "Rozcieńczenie";
            this.button_rozcienczenie.UseVisualStyleBackColor = true;
            this.button_rozcienczenie.Click += new System.EventHandler(this.rozcienczenie_click);
            // 
            // button_wypalanie
            // 
            this.button_wypalanie.Location = new System.Drawing.Point(13, 403);
            this.button_wypalanie.Name = "button_wypalanie";
            this.button_wypalanie.Size = new System.Drawing.Size(126, 23);
            this.button_wypalanie.TabIndex = 13;
            this.button_wypalanie.Text = "Wypalanie";
            this.button_wypalanie.UseVisualStyleBackColor = true;
            this.button_wypalanie.Click += new System.EventHandler(this.wypalanie_click);
            // 
            // button_reflect
            // 
            this.button_reflect.Location = new System.Drawing.Point(13, 433);
            this.button_reflect.Name = "button_reflect";
            this.button_reflect.Size = new System.Drawing.Size(126, 23);
            this.button_reflect.TabIndex = 14;
            this.button_reflect.Text = "Reflect mode";
            this.button_reflect.UseVisualStyleBackColor = true;
            this.button_reflect.Click += new System.EventHandler(this.reflect_click);
            // 
            // button_przezroczystosc
            // 
            this.button_przezroczystosc.Location = new System.Drawing.Point(13, 463);
            this.button_przezroczystosc.Name = "button_przezroczystosc";
            this.button_przezroczystosc.Size = new System.Drawing.Size(126, 23);
            this.button_przezroczystosc.TabIndex = 15;
            this.button_przezroczystosc.Text = "Przeźroczystość";
            this.button_przezroczystosc.UseVisualStyleBackColor = true;
            this.button_przezroczystosc.Click += new System.EventHandler(this.przezroczystosc_click);
            // 
            // pictureBox_zdj_1
            // 
            this.pictureBox_zdj_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_zdj_1.Image = global::GUI.Properties.Resources.floppy_disk;
            this.pictureBox_zdj_1.Location = new System.Drawing.Point(193, 13);
            this.pictureBox_zdj_1.Name = "pictureBox_zdj_1";
            this.pictureBox_zdj_1.Size = new System.Drawing.Size(230, 291);
            this.pictureBox_zdj_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zdj_1.TabIndex = 16;
            this.pictureBox_zdj_1.TabStop = false;
            // 
            // pictureBox_zdj_2
            // 
            this.pictureBox_zdj_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_zdj_2.Image = global::GUI.Properties.Resources.folder;
            this.pictureBox_zdj_2.Location = new System.Drawing.Point(457, 13);
            this.pictureBox_zdj_2.Name = "pictureBox_zdj_2";
            this.pictureBox_zdj_2.Size = new System.Drawing.Size(230, 293);
            this.pictureBox_zdj_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zdj_2.TabIndex = 17;
            this.pictureBox_zdj_2.TabStop = false;
            // 
            // pictureBox_wynik
            // 
            this.pictureBox_wynik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_wynik.Location = new System.Drawing.Point(718, 13);
            this.pictureBox_wynik.Name = "pictureBox_wynik";
            this.pictureBox_wynik.Size = new System.Drawing.Size(230, 293);
            this.pictureBox_wynik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_wynik.TabIndex = 18;
            this.pictureBox_wynik.TabStop = false;
            // 
            // numericUpDown_przezroczystoc
            // 
            this.numericUpDown_przezroczystoc.Location = new System.Drawing.Point(145, 463);
            this.numericUpDown_przezroczystoc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_przezroczystoc.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_przezroczystoc.Name = "numericUpDown_przezroczystoc";
            this.numericUpDown_przezroczystoc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_przezroczystoc.TabIndex = 19;
            this.numericUpDown_przezroczystoc.Scroll += new System.Windows.Forms.ScrollEventHandler(this.wartosc_prze);
            // 
            // Czyszczenie
            // 
            this.Czyszczenie.Location = new System.Drawing.Point(13, 521);
            this.Czyszczenie.Name = "Czyszczenie";
            this.Czyszczenie.Size = new System.Drawing.Size(126, 23);
            this.Czyszczenie.TabIndex = 20;
            this.Czyszczenie.Text = "Wyczysc";
            this.Czyszczenie.UseVisualStyleBackColor = true;
            this.Czyszczenie.Click += new System.EventHandler(this.Czyszenie_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Wynik";
            // 
            // button_negatyw
            // 
            this.button_negatyw.Location = new System.Drawing.Point(13, 492);
            this.button_negatyw.Name = "button_negatyw";
            this.button_negatyw.Size = new System.Drawing.Size(126, 23);
            this.button_negatyw.TabIndex = 22;
            this.button_negatyw.Text = "Negatyw";
            this.button_negatyw.UseVisualStyleBackColor = true;
            this.button_negatyw.Click += new System.EventHandler(this.Negatyw_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "JASNOSC: ";
            // 
            // trackBar_jasnosc
            // 
            this.trackBar_jasnosc.Location = new System.Drawing.Point(789, 343);
            this.trackBar_jasnosc.Maximum = 100;
            this.trackBar_jasnosc.Minimum = -100;
            this.trackBar_jasnosc.Name = "trackBar_jasnosc";
            this.trackBar_jasnosc.Size = new System.Drawing.Size(104, 45);
            this.trackBar_jasnosc.TabIndex = 24;
            this.trackBar_jasnosc.Scroll += new System.EventHandler(this.jasnosc_scroll);
            // 
            // Photoshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 615);
            this.Controls.Add(this.trackBar_jasnosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_negatyw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Czyszczenie);
            this.Controls.Add(this.numericUpDown_przezroczystoc);
            this.Controls.Add(this.pictureBox_wynik);
            this.Controls.Add(this.pictureBox_zdj_2);
            this.Controls.Add(this.pictureBox_zdj_1);
            this.Controls.Add(this.button_przezroczystosc);
            this.Controls.Add(this.button_reflect);
            this.Controls.Add(this.button_wypalanie);
            this.Controls.Add(this.button_rozcienczenie);
            this.Controls.Add(this.button_lag_sw);
            this.Controls.Add(this.button_ost_sw);
            this.Controls.Add(this.button_nakladka);
            this.Controls.Add(this.button_wylaczenie);
            this.Controls.Add(this.button_jasniejsze);
            this.Controls.Add(this.button_ciemniejsze);
            this.Controls.Add(this.button_negacja);
            this.Controls.Add(this.button_mn_odw);
            this.Controls.Add(this.button_mnozenie);
            this.Controls.Add(this.button_różnica);
            this.Controls.Add(this.button_odejmowanie);
            this.Controls.Add(this.button_suma);
            this.Name = "Photoshop";
            this.Text = "GUI by Szymon Kudrewicz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.odejmowanie_click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_przezroczystoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_jasnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.Button button_odejmowanie;
        private System.Windows.Forms.Button button_różnica;
        private System.Windows.Forms.Button button_mnozenie;
        private System.Windows.Forms.Button button_mn_odw;
        private System.Windows.Forms.Button button_negacja;
        private System.Windows.Forms.Button button_ciemniejsze;
        private System.Windows.Forms.Button button_jasniejsze;
        private System.Windows.Forms.Button button_wylaczenie;
        private System.Windows.Forms.Button button_nakladka;
        private System.Windows.Forms.Button button_ost_sw;
        private System.Windows.Forms.Button button_lag_sw;
        private System.Windows.Forms.Button button_rozcienczenie;
        private System.Windows.Forms.Button button_wypalanie;
        private System.Windows.Forms.Button button_reflect;
        private System.Windows.Forms.Button button_przezroczystosc;
        private System.Windows.Forms.PictureBox pictureBox_zdj_1;
        private System.Windows.Forms.PictureBox pictureBox_zdj_2;
        private System.Windows.Forms.PictureBox pictureBox_wynik;
        private System.Windows.Forms.NumericUpDown numericUpDown_przezroczystoc;
        private System.Windows.Forms.Button Czyszczenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_negatyw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_jasnosc;
    }
}


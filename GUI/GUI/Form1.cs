using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Photoshop : Form
    {
        //inicjalizacja zmiennych zdjec miedzyinnymi szerokosc , wysokosc oraz bitmapy
        Image zdj_1;
        Image zdj_2;
        Bitmap bitmapa_zdj1;
        Bitmap bitmapa_zdj2;
        private int zdj_1_szer, zdj_1_wys, zdj_2_szer, zdj_2_wys;
        //pobieranie danych na temat zalaczonych przeze mnie zdjec
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public Photoshop()
        {
            InitializeComponent();
        }
        //klasa zakresu rgb
        public int rgbRange(int value)
        {
            if (value >= 255) return 255;
            if (value <= 0) return 1;
            else return value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            zdj_1 = pictureBox_zdj_1.Image;
            zdj_2 = pictureBox_zdj_2.Image;

            pictureBox_zdj_2.SizeMode = PictureBoxSizeMode.StretchImage;

            zdj_1 = resizeImage(zdj_1, new Size(pictureBox_zdj_1.Size.Width, pictureBox_zdj_1.Size.Height));
            zdj_2 = resizeImage(zdj_2, new Size(pictureBox_zdj_2.Size.Width, pictureBox_zdj_2.Size.Height));

            bitmapa_zdj1 = new Bitmap(zdj_1);
            bitmapa_zdj2 = new Bitmap(zdj_2);

            zdj_1_szer = pictureBox_zdj_1.Width;
            zdj_1_wys = pictureBox_zdj_1.Height;
            zdj_2_szer = pictureBox_zdj_2.Width;
            zdj_2_wys = pictureBox_zdj_2.Height;
        }
        //KLAWISZE DZIALAN
        //Suma
        private void suma_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = rgbRange(zdj_1.A + zdj_2.A);
                    int r = rgbRange(zdj_1.R + zdj_2.R);
                    int g = rgbRange(zdj_1.G + zdj_2.G);
                    int b = rgbRange(zdj_1.B + zdj_2.B);


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //Odejmowanie
        private void odejmowanie_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = rgbRange(zdj_1.A + zdj_2.A - 255);
                    int r = rgbRange(zdj_1.R + zdj_2.R - 255);
                    int g = rgbRange(zdj_1.G + zdj_2.G - 255);
                    int b = rgbRange(zdj_1.B + zdj_2.B - 255);


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //roznica
        private void roznica_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A;
                    int r = rgbRange(Math.Abs(zdj_1.R - zdj_2.R));
                    int g = rgbRange(Math.Abs(zdj_1.G - zdj_2.G));
                    int b = rgbRange(Math.Abs(zdj_1.B - zdj_2.B));


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //mnozenie
        private void mnozenie_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A;
                    int r = rgbRange(zdj_1.R * zdj_2.R);
                    int g = rgbRange(zdj_1.G * zdj_2.G);
                    int b = rgbRange(zdj_1.B * zdj_2.B);


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //mnozenie odwrotnosci
        private void mn_odw_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = rgbRange(255 - rgbRange((255 - zdj_1.A)) * rgbRange(255 - zdj_2.B));
                    int r = rgbRange(255 - rgbRange((255 - zdj_1.R)) * rgbRange(255 - zdj_2.R));
                    int g = rgbRange(255 - rgbRange((255 - zdj_1.G)) * rgbRange(255 - zdj_2.G));
                    int b = rgbRange(255 - rgbRange((255 - zdj_1.B)) * rgbRange(255 - zdj_2.B));


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb((int)a, (int)r, (int)g, (int)b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //negacja
        private void negacja_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A;
                    int r = rgbRange(a - rgbRange(Math.Abs(a - zdj_1.R - zdj_2.R)));
                    int g = rgbRange(a - rgbRange(Math.Abs(a - zdj_1.G - zdj_2.G)));
                    int b = rgbRange(a - rgbRange(Math.Abs(a - zdj_1.B - zdj_2.B)));


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //ciemniejsze
        private void ciemniejsze_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A, r, g, b;

                    if (zdj_1.R < zdj_2.R)
                        r = zdj_2.R;
                    else
                        r = zdj_2.R;

                    if (zdj_1.G < zdj_2.G)
                        g = zdj_1.G;
                    else
                        g = zdj_2.G;

                    if (zdj_1.B < zdj_2.B)
                        b = zdj_1.B;
                    else
                        b = zdj_2.B;

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //jasniejsze
        private void jasniejsze_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a, r, g, b;
                    if (zdj_1.A > zdj_2.A)
                        a = zdj_1.A;
                    else
                        a = zdj_2.A;

                    if (zdj_1.R > zdj_2.R)
                        r = zdj_2.R;
                    else
                        r = zdj_2.R;

                    if (zdj_1.G > zdj_2.G)
                        g = zdj_1.G;
                    else
                        g = zdj_2.G;

                    if (zdj_1.B > zdj_2.B)
                        b = zdj_1.B;
                    else
                        b = zdj_2.B;


                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //wylaczenie
        private void wyl_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = 255;
                    int r = rgbRange(zdj_1.R + zdj_2.R - rgbRange(2 * a * (zdj_1.R * zdj_2.R)));
                    int g = rgbRange(zdj_1.G + zdj_2.G - rgbRange(2 * a * (zdj_1.G * zdj_2.G)));
                    int b = rgbRange(zdj_1.B + zdj_2.B - rgbRange(2 * a * (zdj_1.B * zdj_2.B)));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                }
                pictureBox_wynik.Image = bitmapa_zdj1;
            }
        }
        //nakladka
        private void nakladka_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A, r, g, b;

                    if (zdj_1.R < a * 0.5)
                        r = rgbRange(2 * zdj_1.R * zdj_2.R);
                    else
                        r = rgbRange(1 - 2 * (1 - zdj_1.R) * (1 - zdj_2.R));

                    if (zdj_1.G < a * 0.5)
                        g = rgbRange(2 * zdj_1.G * zdj_2.G);
                    else
                        g = rgbRange(1 - 2 * (1 - zdj_1.G) * (1 - zdj_2.G));

                    if (zdj_1.B < a * 0.5)
                        b = rgbRange(2 * zdj_1.B * zdj_2.B);
                    else
                        b = rgbRange(1 - 2 * (1 - zdj_1.B) * (1 - zdj_2.B));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //ostre swiatlo
        private void ostre_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A, r, g, b;

                    if (zdj_2.R < a * 0.5)
                        r = rgbRange(510 * zdj_1.R * zdj_2.R);
                    else
                        r = rgbRange(a - 510 * (255 - zdj_1.R) * (255 - zdj_2.R));

                    if (zdj_2.G < a * 0.5)
                        g = rgbRange(510 * zdj_1.G * zdj_2.G);
                    else
                        g = rgbRange(a - 510 * (255 - zdj_1.G) * (255 - zdj_2.G));

                    if (zdj_2.B < a * 0.5)
                        b = rgbRange(510 * zdj_1.B * zdj_2.B);
                    else
                        b = rgbRange(a - 510 * (255 - zdj_1.B) * (255 - zdj_2.B));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //lagodne swiatlo
        private void lagodne_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = zdj_1.A, r, g, b;

                    if (zdj_2.R < a * 0.5)
                        r = rgbRange( 510 * zdj_1.R * zdj_2.R + (zdj_1.R^2)*(255-(510*zdj_2.R)));
                    else
                        r = rgbRange( (int) Math.Sqrt(a) * (510 * zdj_2.R - 255) + (510 * zdj_1.R) * (255 - zdj_2.R) );

                    if (zdj_2.G < a * 0.5)
                        g = rgbRange( 510 * zdj_1.G * zdj_2.G + (zdj_1.G ^ 2) * (255 - (510 * zdj_2.G)));
                    else
                        g = rgbRange( (int) Math.Sqrt(a) * (510 * zdj_2.G - 255) + (510 * zdj_1.G) * (255 - zdj_2.G) );
                    
                    if (zdj_2.B < a * 0.5)
                        b = rgbRange( 510 * zdj_1.B * zdj_2.B + (zdj_1.B ^ 2) * ( 255 - ( 510 * zdj_2.B) ) );
                    else
                        b = rgbRange( (int) Math.Sqrt(a) * (510 * zdj_2.B - 255) + (510 * zdj_1.B) * (255 - zdj_2.B) );

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //rozcienczenie
        private void rozcienczenie_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);

                    int a = rgbRange(zdj_1.A / rgbRange((255 - zdj_2.A)));
                    int r = rgbRange(zdj_1.R / rgbRange((255 - zdj_2.R)));
                    int g = rgbRange(zdj_1.G / rgbRange((255 - zdj_2.G)));
                    int b = rgbRange(zdj_1.B / rgbRange((255 - zdj_2.B)));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }

        private void wartosc_prze(object sender, ScrollEventArgs e)
        {

        }
        //czyszczenie wyniku
        private void Czyszenie_click(object sender, EventArgs e)
        {

            bitmapa_zdj1 = new Bitmap(zdj_1);
            pictureBox_wynik.Image = null;
            
        }

        private void Negatyw_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    int a = zdj_1.A;
                    int r = zdj_1.R;
                    int g = zdj_1.G;
                    int b = zdj_1.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //jasnosc na podstawie bitmapy
        public static Bitmap jasnosc(Bitmap Image, int Value)
        {
            Bitmap tempBitmap = Image;
            float finalValue = (float)Value / 255.0f;
            Bitmap newBitmap = new Bitmap(tempBitmap.Width, tempBitmap.Height);
            Graphics newGraphics = Graphics.FromImage(newBitmap);
            float[][] floatColorMatrix =
            {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {finalValue,finalValue,finalValue,1,1}
            };
            ColorMatrix newcolorMatrix = new ColorMatrix(floatColorMatrix);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(newcolorMatrix);
            newGraphics.DrawImage(tempBitmap, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height), 0, 0,
                tempBitmap.Width, tempBitmap.Height, GraphicsUnit.Pixel, attributes);
            attributes.Dispose();
            newGraphics.Dispose();

            return newBitmap;
        }
        private void jasnosc_scroll(object sender, EventArgs e)
        {
            pictureBox_wynik.Image = jasnosc(bitmapa_zdj1, trackBar_jasnosc.Value);
        }

        //wypalanie
        private void wypalanie_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);
                    int a = rgbRange(255 - (255 - zdj_1.A) / rgbRange(zdj_2.A));
                    int r = rgbRange(255 - (255 - zdj_1.R) / rgbRange(zdj_2.R));
                    int g = rgbRange(255 - (255 - zdj_1.G) / rgbRange(zdj_2.G));
                    int b = rgbRange(255 - (255 - zdj_1.B) / rgbRange(zdj_2.B));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //reflect mode
        private void reflect_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);

                    int a = rgbRange((int)(Math.Pow(zdj_1.A, 2) / rgbRange(255 - zdj_2.A)));
                    int r = rgbRange((int)(Math.Pow(zdj_1.R, 2) / rgbRange(255 - zdj_2.R)));
                    int g = rgbRange((int)(Math.Pow(zdj_1.G, 2) / rgbRange(255 - zdj_2.G)));
                    int b = rgbRange((int)(Math.Pow(zdj_1.B, 2) / rgbRange(255 - zdj_2.B)));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
        //przezroczystosc
        private void przezroczystosc_click(object sender, EventArgs e)
        {
            for (int y = 0; y < zdj_1_wys; y++)
            {
                for (int x = 0; x < zdj_1_szer; x++)
                {
                    Color zdj_1 = bitmapa_zdj1.GetPixel(x, y);
                    Color zdj_2 = bitmapa_zdj2.GetPixel(x, y);

                    int a = rgbRange(( (int) numericUpDown_przezroczystoc.Value * ((zdj_2.A + 127) - zdj_1.A)) / 255 + zdj_1.A - ( (int) numericUpDown_przezroczystoc.Value / 4));
                    int r = rgbRange(( (int) numericUpDown_przezroczystoc.Value * ((zdj_2.R + 127) - zdj_1.R)) / 255 + zdj_1.R - ( (int) numericUpDown_przezroczystoc.Value / 4));
                    int g = rgbRange(( (int) numericUpDown_przezroczystoc.Value * ((zdj_2.G + 127) - zdj_1.G)) / 255 + zdj_1.G - ( (int) numericUpDown_przezroczystoc.Value / 4));
                    int b = rgbRange(( (int) numericUpDown_przezroczystoc.Value * ((zdj_2.B + 127) - zdj_1.B)) / 255 + zdj_1.B - ( (int) numericUpDown_przezroczystoc.Value / 4));

                    bitmapa_zdj1.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox_wynik.Image = bitmapa_zdj1;
        }
    }
}

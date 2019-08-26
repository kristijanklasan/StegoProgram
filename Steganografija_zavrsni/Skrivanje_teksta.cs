using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganografija_zavrsni
{
    public partial class Skrivanje_teksta : Form
    {
        public Skrivanje_teksta()
        {
            InitializeComponent();
        }

        public string lokacija_slike = "";
        public string lokacija_slike2 = "";
        public int brojac=0;
        public int brojac2 = 0;
        public int brojac3 = 0; 
        public int vrij;
        public char slova; 

        #region Izbornik hover 

        private void btnSkrivanje_teksta_MouseEnter(object sender, EventArgs e)
        {
            this.btnSkrivanje_teksta.BackColor = ColorTranslator.FromHtml("#0099ff");
        }

        private void btnSkrivanje_teksta_MouseLeave(object sender, EventArgs e)
        {
            this.btnSkrivanje_teksta.BackColor = ColorTranslator.FromHtml("#1A2028");
        }

        private void btnOtkrivanje_teksta_MouseEnter(object sender, EventArgs e)
        {
            this.btnOtkrivanje_teksta.BackColor = ColorTranslator.FromHtml("#0099ff");
        }

        private void btnOtkrivanje_teksta_MouseLeave(object sender, EventArgs e)
        {
            this.btnOtkrivanje_teksta.BackColor = ColorTranslator.FromHtml("#1A2028");
        }

        private void btnSkrivanje_slike_MouseEnter(object sender, EventArgs e)
        {
            this.btnSkrivanje_slike.BackColor = ColorTranslator.FromHtml("#0099ff");
        }

        private void btnSkrivanje_slike_MouseLeave(object sender, EventArgs e)
        {
            this.btnSkrivanje_slike.BackColor = ColorTranslator.FromHtml("#1A2028");
        }

        private void btnOtkrivanje_slike_MouseEnter(object sender, EventArgs e)
        {
            this.btnOtkrivanje_slike.BackColor = ColorTranslator.FromHtml("#0099ff");
        }

        private void btnOtkrivanje_slike_MouseLeave(object sender, EventArgs e)
        {
            this.btnOtkrivanje_slike.BackColor = ColorTranslator.FromHtml("#1A2028");
        }

        private void btnUsporedi_MouseEnter(object sender, EventArgs e)
        {
            this.btnUsporedi.BackColor = ColorTranslator.FromHtml("#0099ff");
        }

        private void btnUsporedi_MouseLeave(object sender, EventArgs e)
        {
            this.btnUsporedi.BackColor = ColorTranslator.FromHtml("#1A2028");
        }

        #endregion

        #region Izbornik

        private void btnSkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_teksta tekst = new Skrivanje_teksta();
            tekst.Show(); 
        }

        private void btnOtkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta otkrivanje_teksta = new Otkrivanje_teksta();
            otkrivanje_teksta.Show(); 
        }

        private void btnSkrivanje_slike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_slike skrivanje = new Skrivanje_slike();
            skrivanje.Show(); 
        }

        private void btnOtkrivanje_slike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_slike otkrivanje = new Otkrivanje_slike();
            otkrivanje.Show(); 
        }

        private void btnUsporedi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usporedi_slike usporedi = new Usporedi_slike();
            usporedi.Show(); 
        }

        #endregion

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg. files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike = dialog.FileName.ToString();
                textBox1.Text = lokacija_slike;
                pictureBox1.ImageLocation = lokacija_slike;
            }

            if (lokacija_slike != "")
            {
                provjeri_velicinu();
            }
        }

        public void provjeri_velicinu()
        {
            Bitmap provjera = new Bitmap(lokacija_slike); 
            
           label7.Text = provjera.Height + " piksela";
           label8.Text = provjera.Width  + " piksela";
           
            Label labele;
            for (int j = 5; j <= 8; j++)
            {
                labele = (Label)this.Controls["Label" + j];
                labele.Visible = true;
            }
            pictureBox4.Visible = true;
            btnPokreni.Visible = true;
            label13.Visible = true;
        }
        public void sakrij_tekst()
        {
            Bitmap slika = new Bitmap(lokacija_slike);

            DialogResult upitnik = MessageBox.Show("Želite li pokrenuti postupak skrivanja teksta unutar slike?", "Skrivanje teksta u sliku?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (upitnik == DialogResult.OK)
            {
                MessageBox.Show("Proces skrivanja će potrajati nekoliko sekundi!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var velicina_teksta = textBox2.TextLength;

                for (int i = 0; i < slika.Width; i++)
                {
                    for (int j = 0; j < slika.Height; j++)
                    {
                        Color pikseli = slika.GetPixel(i, j);
                        if (i == slika.Width - 1 && j == slika.Height - 1)
                        {

                            var pikselR = pikseli.R - pikseli.R % 64;
                            var pikselG = pikseli.G - pikseli.G % 64;
                            var pikselB = pikseli.B - pikseli.B % 16;

                            var velicina_teksta1 = velicina_teksta / 1024;
                            var velicina = velicina_teksta % 1024;
                            var velicina_teksta2 = velicina / 16;

                            var velicina_teksta3 = velicina % 16;
                            pikselR = pikselR + velicina_teksta1;
                            pikselG = pikselG + velicina_teksta2;
                            pikselB = pikselB + velicina_teksta3;

                            slika.SetPixel(i, j, Color.FromArgb(pikselR, pikselG, pikselB));
                        }
                        try
                        {
                            if (brojac == 0)
                            {
                                if (brojac2 < velicina_teksta)
                                {
                                    slova = Convert.ToChar(textBox2.Text.Substring(brojac2, 1));
                                    vrij = Convert.ToInt32(slova);
                                }  
                            }

                            if (brojac2 < velicina_teksta)
                            {
                                int pikselR = pikseli.R - pikseli.R % 2;
                                int pikselG = pikseli.G - pikseli.G % 2;
                                int pikselB = pikseli.B - pikseli.B % 2;

                                brojac++;

                                switch (brojac)
                                {
                                    case 1:
                                        {
                                            int r = vrij / 128;
                                            pikselR = pikselR + r;

                                            int g1 = vrij / 64;
                                            int g = g1 % 2;
                                            pikselG = pikselG + g;

                                            int b1 = vrij / 32;
                                            int b = b1 % 2;
                                            pikselB = pikselB + b;

                                            slika.SetPixel(i, j, Color.FromArgb(pikselR, pikselG, pikselB));
                                        }
                                        break;
                                    case 2:
                                        {
                                            int r2 = vrij / 16;
                                            int r = r2 % 2;
                                            pikselR = pikselR + r;

                                            int g2 = vrij / 8;
                                            int g = g2 % 2;
                                            pikselG = pikselG + g;

                                            int b2 = vrij / 4;
                                            int b = b2 % 2;
                                            pikselB = pikselB + b;

                                            slika.SetPixel(i, j, Color.FromArgb(pikselR, pikselG, pikselB));
                                        }
                                        break;
                                    case 3:
                                        {
                                            int r3 = vrij / 2;
                                            int r = r3 % 2;
                                            pikselR = pikselR + r;

                                            int g3 = vrij % 2 ;
                                            pikselG = pikselG + g3;

                                            slika.SetPixel(i, j, Color.FromArgb(pikselR, pikselG, pikselB));
                                            brojac = 0;
                                            brojac2++;
                                        }
                                        break;
                                }
                                tekst(velicina_teksta);
                                label9.Visible = true;
                                label10.Visible = true;
                            }
                        }
                        catch (Exception e)
                        {
                            string poruka = "Odaberite veću sliku za unos teksta!";
                            string naslov = "Greška!";
                            MessageBox.Show(poruka, naslov, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            pictureBox2.Image= slika; 
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SaveFileDialog spremi = new SaveFileDialog();
            spremi.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            Bitmap slika2 = new Bitmap(pictureBox2.Image);
            if (spremi.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike2 = spremi.FileName.ToString();
                slika2.Save(lokacija_slike2);
            }
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            sakrij_tekst();
            btnSpremi.Visible = true;
            btnPokreni.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_teksta tekst = new Skrivanje_teksta();
            tekst.Show();
        }

        private void btnTekst_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_tekst = new OpenFileDialog();
            dialog_tekst.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            dialog_tekst.RestoreDirectory = true;

            if (dialog_tekst.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(dialog_tekst.FileName);
                label14.Text = dialog_tekst.FileName.ToString();
            }
        }

        public void tekst(int broj)
        {
            if(broj%10 == 1)
            {
                label9.Text = broj + " znak";
            }
            else if(broj%10 == 0 || (broj % 10 > 4 || broj / 10 != 0))
            {
                label9.Text = broj + " znakova";
            }
            else
            {
                for(int i =2; i<=4; i++)
                {
                    label9.Text = broj + " znaka";
                }
            }
        }
    }
}

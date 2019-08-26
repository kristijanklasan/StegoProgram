using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganografija_zavrsni
{
    public partial class Skrivanje_slike : Form
    {
        public Skrivanje_slike()
        {
            InitializeComponent();
        }

        public string lokacija_slike1 = "";
        public string lokacija_slike2 = "";
        public bool vidljivost = false;

        #region Hover

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
            Skrivanje_teksta skrivanje = new Skrivanje_teksta();
            skrivanje.Show(); 
        }

        private void btnSkrivanje_slike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_slike slike = new Skrivanje_slike();
            slike.Show(); 
        }

        private void btnOtkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta otkrivanje = new Otkrivanje_teksta();
            otkrivanje.Show(); 
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

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); 
            dialog.Filter = "png files(*.png)|*.png|jpg. files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike1 = dialog.FileName.ToString();
                textBox1.Text = lokacija_slike1;
                pictureBox2.ImageLocation = lokacija_slike1; 

            }
        }

        private void btnStego_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog2 = new OpenFileDialog();
            dialog2.Filter = "png files(*.png)|*.png|jpg. files(*.jpg)|*.jpg|All files(*.*)|*.*"; 

            if(dialog2.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike2 = dialog2.FileName.ToString();
                textBox2.Text = lokacija_slike2;
                pictureBox3.ImageLocation = lokacija_slike2; 
            }
        }

        public void bitovi()
        {
            try
            {
                int original;
                int skrivena;

                int bit = Convert.ToInt32(labelBrojac.Text);

                switch (bit)
                {
                    case 1:
                        {
                            original = 2;
                            skrivena = 128;
                            proces_skrivanja(original, skrivena);
                        }
                        break;

                    case 2:
                        {
                            original = 4;
                            skrivena = 64;
                            proces_skrivanja(original, skrivena);
                        }
                        break;
                    case 3:
                        {
                            original = 8;
                            skrivena = 32;
                            proces_skrivanja(original, skrivena);

                        }
                        break;

                    case 4:
                        {
                            original = 16;
                            skrivena = 16;
                            proces_skrivanja(original, skrivena);
                        }
                        break;

                    case 5:
                        {
                            original = 32;
                            skrivena = 8;
                            proces_skrivanja(original, skrivena);
                        }
                        break;

                    case 6:
                        {
                            original = 64;
                            skrivena = 4;
                            proces_skrivanja(original, skrivena);
                        }
                        break;

                    case 7:
                        {
                            original = 128;
                            skrivena = 2;
                            proces_skrivanja(original, skrivena);
                        }
                        break;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Molimo odaberite bit pod kojim želite sakriti sliku!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void proces_skrivanja(int javno, int tajno)
        {
            var original = lokacija_slike1;
            var skrivena = lokacija_slike2;

            Bitmap original1 = (Bitmap)Image.FromFile(lokacija_slike1);
            Bitmap skrivena1 = (Bitmap)Image.FromFile(lokacija_slike2);

            var originalSirina = original1.Width;
            var skrivenaSirina = original1.Width;

            if (skrivenaSirina < originalSirina)
            {
                originalSirina = skrivenaSirina;
            }
            else
            {
                skrivenaSirina = originalSirina;
            }

            var originalVisina = original1.Height;
            var skrivenaVisina = skrivena1.Height;

            if (skrivenaVisina < originalVisina)
            {
                originalVisina = skrivenaVisina;
            }
            else
            {
                skrivenaVisina = originalVisina;
            }

            Bitmap original_slika = new Bitmap(original1, new Size(originalSirina, originalVisina));
            Bitmap skrivena_slika = new Bitmap(skrivena1, new Size(skrivenaSirina, skrivenaVisina));
            Bitmap stego_slika = new Bitmap(original_slika);

            for (int i = 0; i < original_slika.Width; i++)
            {
                for (int j = 0; j < original_slika.Height; j++)
                {
                    Color piksel = original_slika.GetPixel(i, j);
 
                    double rj1 = (piksel.R / javno) * javno;
                    int rezultat1 = (int)rj1;

                    double rj2 = (piksel.G / javno) * javno;
                    int rezultat2 = (int)rj2;

                    double rj3 = (piksel.B / javno) * javno;
                    int rezultat3 = (int)rj3;

                    original_slika.SetPixel(i, j, Color.FromArgb(rezultat1, rezultat2, rezultat3));

                    if (checkBoxDetalji.Checked == true)
                    {
                        pictureBox2.Image = original_slika;
                    }
                }
            }

            for (int x = 0; x < skrivena_slika.Width; x++)
            {
                for (int y = 0; y < skrivena_slika.Height; y++)
                {
                    Color pikseli = skrivena_slika.GetPixel(x, y);

                    double rez1 = (pikseli.R / tajno);
                    int rjesenje1 = (int)rez1;

                    double rez2 = (pikseli.G / tajno);
                    int rjesenje2 = (int)rez2;

                    double rez3 = (pikseli.B / tajno);
                    int rjesenje3 = (int)rez3;

                    skrivena_slika.SetPixel(x, y, Color.FromArgb(rjesenje1, rjesenje2, rjesenje3));

                    if (checkBoxDetalji.Checked == true)
                    {
                        pictureBox3.Image = skrivena_slika;
                    }
                }
            }
            for (int u = 0; u < stego_slika.Width; u++)
            {
                for (int z = 0; z < stego_slika.Height; z++)
                {
                    Color piksel_original = original_slika.GetPixel(u, z);
                    Color piksel_skrivena = skrivena_slika.GetPixel(u, z);

                    var glavni1 = piksel_original.R + piksel_skrivena.R;
                    var glavni2 = piksel_original.G + piksel_skrivena.G;
                    var glavni3 = piksel_original.B + piksel_skrivena.B;

                    stego_slika.SetPixel(u, z, Color.FromArgb(glavni1, glavni2, glavni3));
                    pictureBox4.Image = stego_slika;
                }
            }
        }

        public void spremi_sliku()
        {
            SaveFileDialog spremi = new SaveFileDialog();
            spremi.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            string nova_lokacija = "";

            if (spremi.ShowDialog() == DialogResult.OK)
            {
                nova_lokacija = spremi.FileName.ToString();
                Bitmap slika_spremi = new Bitmap(pictureBox4.Image);

                slika_spremi.Save(nova_lokacija);
            }
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            provjeri_slike();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {         
            spremi_sliku();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox slike;

            for (int j = 2; j <= 4; j++)
            {
                slike = (PictureBox)this.Controls["PictureBox" + j];
                slike.Image = null;
            }

            btnSpremi.Visible = false;
            textBox1.Text = null;
            textBox2.Text = null; 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelBrojac.Text = trackBar1.Value.ToString();
        }

        private void provjeri_slike()
        {
            if(pictureBox2.ImageLocation == null)
            {
                MessageBox.Show("Odaberite sliku pod koji želite sakriti sadržaj!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (pictureBox3.ImageLocation == null)
            {
                MessageBox.Show("Odaberite sliku koju želite sakriti!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                DialogResult upitnik = MessageBox.Show("Želite li pokrenuti postupak skrivanja slike unutar slike?", "Skrivanje slike u sliku?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (upitnik == DialogResult.OK)
                {
                    MessageBox.Show("Postupak skrivanje slike unutar slike će potrajati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bitovi();
                    btnSpremi.Visible = true;
                }
                MessageBox.Show("Postupak skrivanja je završio!", "Proces je završio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

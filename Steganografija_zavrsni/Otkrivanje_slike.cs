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
    public partial class Otkrivanje_slike : Form
    {
        public Otkrivanje_slike()
        {
            InitializeComponent();
        }

        public string lokacija_slike = "";
        public bool original = false;
        public bool skrivena = false; 

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
            Skrivanje_teksta skrivanje_teksta = new Skrivanje_teksta();
            skrivanje_teksta.Show(); 
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
            Skrivanje_slike slika = new Skrivanje_slike();
            slika.Show(); 
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

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike = dialog.FileName.ToString();
                textBox1.Text = lokacija_slike;
                pictureBox1.ImageLocation = lokacija_slike; 
            }

            if (lokacija_slike != "")
            {
                provjera_dimenzija();
            }
        }

        public void provjera_dimenzija()
        {
            Bitmap slika = new Bitmap(lokacija_slike);

            label8.Text = slika.Width + " piksela";
            label7.Text = slika.Height + " piksela";

            Label labele;
            for (int j = 5; j <= 8; j++)
            {
                labele = (Label)this.Controls["Label" + j];
                labele.Visible = true;
            }

            btnOtkrij.Visible = true;
            pictureBox5.Visible = true;
        }

        public void odaberi_bit()
        {
            try
            {
                int bit;

                int bitovi = Convert.ToInt32(labelBrojac.Text);
                int skriveni_bit;

                switch (bitovi)
                {
                    case 1:
                        {
                            bit = 2;
                            skriveni_bit = 128;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 2:
                        {
                            bit = 4;
                            skriveni_bit = 64;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 3:
                        {
                            bit = 8;
                            skriveni_bit = 32;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 4:
                        {
                            bit = 16;
                            skriveni_bit = 16;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 5:
                        {
                            bit = 32;
                            skriveni_bit = 8;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 6:
                        {
                            bit = 64;
                            skriveni_bit = 4;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;

                    case 7:
                        {
                            bit = 128;
                            skriveni_bit = 2;
                            otkrivanje_skrivene_slike(bit, skriveni_bit);
                            otkrivanje_original_slike(bit);
                        }
                        break;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Molim odaberite bit za otkrivanje!","Obavijest",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void otkrivanje_skrivene_slike(int odabrani_bit,int skriveni)
        {
            Bitmap slika1 = new Bitmap(lokacija_slike);

            for (int i=0; i<slika1.Width; i++)
            {
                for(int j=0; j<slika1.Height; j++)
                {
                    Color piksel = slika1.GetPixel(i, j);

                    int vrijednost1 =(piksel.R % odabrani_bit)* skriveni;
                    int vrijednost2 =(piksel.G % odabrani_bit)* skriveni;
                    int vrijednost3 = (piksel.B % odabrani_bit)* skriveni;

                    slika1.SetPixel(i, j, Color.FromArgb(vrijednost1, vrijednost2, vrijednost3));
                    pictureBox2.Image = slika1;

                    skrivena = true; 
                }
            }
        }

        public void otkrivanje_original_slike(int odabrani_bit)
        {
            Bitmap original_slika = new Bitmap(lokacija_slike);

            for(int i=0; i<original_slika.Width; i++)
            {
                for(int j=0; j<original_slika.Height; j++)
                {

                    Color pikseli = original_slika.GetPixel(i, j); 

                    int vrijednost21 = (pikseli.R / odabrani_bit) * odabrani_bit;
                    int vrijednost22 = (pikseli.G / odabrani_bit) * odabrani_bit;
                    int vrijednost23 = (pikseli.B / odabrani_bit) * odabrani_bit;
           
                    original_slika.SetPixel(i, j, Color.FromArgb(vrijednost21, vrijednost22, vrijednost23));
                    pictureBox3.Image = original_slika;

                    original = true; 
                }
            }
        }

        private void btnOtkrij_Click(object sender, EventArgs e)
        {
            provjeri_tekst();
            DialogResult upitnik = MessageBox.Show("Želite li pokrenuti postupak otkrivanja sadržaja slike?", "Otkrivanje sadržaja iz slike?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (upitnik == DialogResult.OK)
            {
                odaberi_bit(); 

                if (original == true && skrivena == true)
                {
                    btnSpremi_original.Visible = true;
                    btnSpremi_skrivenu.Visible = true;
                }
            }
            MessageBox.Show("Proces otkrivanja je završio!", "postupak je gotov", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSpremi_skrivenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog spremi_skrivenu = new SaveFileDialog();
            spremi_skrivenu.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            string nova_lokacija = "";

            if (spremi_skrivenu.ShowDialog() == DialogResult.OK)
            {
                nova_lokacija = spremi_skrivenu.FileName.ToString();
                Bitmap slika_spremi_skrivenu = new Bitmap(pictureBox2.Image);

                slika_spremi_skrivenu.Save(nova_lokacija);
            }
        }

        private void btnSpremi_original_Click(object sender, EventArgs e)
        {
            SaveFileDialog spremi_original = new SaveFileDialog();
            spremi_original.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            string nova_lokacija = "";

            if (spremi_original.ShowDialog() == DialogResult.OK)
            {
                nova_lokacija = spremi_original.FileName.ToString();
                Bitmap slika_spremi_original = new Bitmap(pictureBox3.Image);

                slika_spremi_original.Save(nova_lokacija);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Label tekst;

            for (int j = 5; j <= 8; j++)
            {
                tekst = (Label)this.Controls["Label" + j];
                tekst.Visible = false;
            }

            PictureBox slike; 

            for(int i = 1; i<=3; i++)
            {
                slike = (PictureBox)this.Controls["PictureBox" + i];
                slike.Image = null; 
     
            }
            textBox1.Text = null; 
            btnOtkrij.Visible = false;
            btnSpremi_skrivenu.Visible = false;
            btnSpremi_original.Visible = false; 
        }

        private void provjeri_tekst()
        {
            if(pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Molimo odaberite sliku za otkrivanje!", "Odabir slike za otkrivanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelBrojac.Text = trackBar1.Value.ToString();
        }
    }
}

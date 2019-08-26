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
    public partial class Usporedi_slike : Form
    {
        public Usporedi_slike()
        {
            InitializeComponent();
        }

        public string lokacija_slike1 = "";
        public string lokacija_slike2 = "";


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
        private void btnOtkrivanje_slike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_slike otkrivanje = new Otkrivanje_slike();
            otkrivanje.Show();
        }

        private void btnSkrivanje_slike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_slike skrivanje = new Skrivanje_slike();
            skrivanje.Show();
        }

        private void btnOtkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta otkrivanje_teksta = new Otkrivanje_teksta();
            otkrivanje_teksta.Show(); 
        }

        private void btnSkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_teksta tekst = new Skrivanje_teksta();
            tekst.Show(); 
        }

        private void btnUsporedi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usporedi_slike usporedi = new Usporedi_slike();
            usporedi.Show(); 
        }

        #endregion

        private void btnPrva_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg. files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike1 = dialog.FileName.ToString();
                textBox1.Text = lokacija_slike1;
                pictureBox1.ImageLocation = lokacija_slike1;
            }
        }

        private void btnDruga_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog2 = new OpenFileDialog();
            dialog2.Filter = "png files(*.png)|*.png|jpg. files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog2.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike2 = dialog2.FileName.ToString();
                textBox2.Text = lokacija_slike2;
                pictureBox2.ImageLocation = lokacija_slike2;
            }
        }

        public void razlika_slika()
        {
            Bitmap prva_slika = new Bitmap(lokacija_slike1);
            Bitmap druga_slika = new Bitmap(lokacija_slike2);

            int sirina = Math.Min(prva_slika.Width, druga_slika.Width);
            int visina = Math.Min(prva_slika.Height, druga_slika.Height);

            Bitmap treca_slika = new Bitmap(sirina, visina);

            int brojac_poz = 0;
            int brojac_neg = 0;

            Color poz_odgovor = Color.White;
            Color neg_odgovor = Color.Red;

            for (int i = 0; i < treca_slika.Width; i++)
            {
                for (int j = 0; j < treca_slika.Height; j++)
                {
                    Color piksel = prva_slika.GetPixel(i, j);
                    Color piksel2 = druga_slika.GetPixel(i, j);
                    if (piksel.Equals(piksel2))
                    {
                        if (piksel.R == piksel2.R && piksel.G == piksel2.G && piksel.B == piksel2.B)
                        {
                            treca_slika.SetPixel(i, j, poz_odgovor);
                            brojac_poz = brojac_poz + 1;
                        }
                    }
                    else
                    {
                        treca_slika.SetPixel(i, j, neg_odgovor);
                        brojac_neg = brojac_neg + 1;
                    }
                }
            }

            if (brojac_neg == 0)
            {
                labelRezultat.Text = "Slike su identične!";
                labelRezultat.BackColor = Color.Green;
            }
            else
            {
                labelRezultat.Text = "Slike su različite!";
                labelRezultat.BackColor = Color.Red;
            }

            pictureBox3.Image = treca_slika;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            razlika_slika(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PictureBox slike; 

            for(int i = 1; i<=3; i++)
            {
                slike = (PictureBox)this.Controls["PictureBox" + i];
                slike.Image = null; 
            }
            labelRezultat.Visible = false;
            textBox1.Text = null;
            textBox2.Text = null; 
        }
    }
}

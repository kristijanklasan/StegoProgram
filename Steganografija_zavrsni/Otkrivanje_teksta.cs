using System;
using System.Collections;
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
    public partial class Otkrivanje_teksta : Form
    {
        public Otkrivanje_teksta()
        {
            InitializeComponent();
        }

        public string lokacija_slike = "";
        public int brojac;
        public int brojac2 = 0; 
        public int zbroj;

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
            Skrivanje_teksta skrivanje_teksta = new Skrivanje_teksta();
            skrivanje_teksta.Show();
        }

        private void btnOtkrivanje_teksta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta otkrivanje_teksta = new Otkrivanje_teksta();
            otkrivanje_teksta.Show();
        }

        private void btnSkrivanje_slike_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_slike skrivanje = new Skrivanje_slike();
            skrivanje.Show();
        }

        private void btnOtkrivanje_slike_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_slike otkrivanje_slike = new Otkrivanje_slike();
            otkrivanje_slike.Show();
        }

        private void btnUsporedi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Usporedi_slike usporedi = new Usporedi_slike();
            usporedi.Show();
        }

        private void btnOtkrivanje_teksta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta otkrivanje_teksta = new Otkrivanje_teksta();
            otkrivanje_teksta.Show();
        }

        #endregion

        private void btnOtkrij_Click(object sender, EventArgs e)
        {
            DialogResult upitnik = MessageBox.Show("Želite li pokrenuti postupak otkrivanja teksta iz slike?", "Otkrivanje teksta iz slike?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (upitnik == DialogResult.OK)
            {
                otkrij_tekst();
                btnSpremi.Visible = true;
                label14.Visible = true;
            }
        }

        public void otkrij_tekst()
        {
            Bitmap otkrij = new Bitmap(textBox1.Text);

            Color zadnji = otkrij.GetPixel(otkrij.Width-1, otkrij.Height-1);
            
            int vrij1 = zadnji.R % 64;
            int vrij2 = zadnji.G % 64;
            int vrij3 = zadnji.B % 16;

            BitArray bit = new BitArray(16);

            int ostatak,ostatak2,ostatak3=0;

            for(int bb=0; bb<16; bb++)
            {
                if (bb < 4)
                {
                    ostatak = vrij3 % 2;
                    var ostatak1 = Convert.ToBoolean(ostatak);
                    vrij3 /= 2;
                    bit.Set(bb, ostatak1);
                }

                if (bb>3 && bb < 10)
                {
                    ostatak2 = vrij2 % 2;
                    var ostatak22 = Convert.ToBoolean(ostatak2);
                    vrij2 /= 2;
                    bit.Set(bb, ostatak22);
                }

                if (bb>9 && bb < 16)
                {
                    ostatak3 = vrij1 % 2;
                    var ostatak33 = Convert.ToBoolean(ostatak3);
                    vrij1 /= 2;
                    bit.Set(bb, ostatak33);
                }
            }
            int min_vrijednost = pretvoriInt(bit);
            string cijeli_tekst = "";
            int [] polje = new int[8];

            for (int i = 0; i < otkrij.Width; i++)
            {
                for (int j = 0; j < otkrij.Height; j++)
                {
                    Color pikseli = otkrij.GetPixel(i, j);

                    if (brojac2 < min_vrijednost)
                    { 
                        brojac++;
                        switch (brojac)
                        {
                            case 1:
                                {
                                    int pikseliR = pikseli.R % 2;
                                    bool pikselR = Convert.ToBoolean(pikseliR);
                                    polje.SetValue(pikseliR, 7); 

                                    int pikseliG = pikseli.G % 2;
                                    bool pikselG = Convert.ToBoolean(pikseliG);
                                    polje.SetValue(pikseliG, 6);

                                    int pikseliB = pikseli.B % 2;
                                    bool pikselB = Convert.ToBoolean(pikseliB);
                                    polje.SetValue(pikseliB, 5);
                                }
                                break;
                            case 2:
                                {
                                    int pikseliR = pikseli.R % 2;
                                    bool pikselR = Convert.ToBoolean(pikseliR);
                                    polje.SetValue(pikseliR, 4);

                                    int pikseliG = pikseli.G % 2;
                                    bool pikselG = Convert.ToBoolean(pikseliG);
                                    polje.SetValue(pikseliG, 3);

                                    int pikseliB = pikseli.B % 2;
                                    bool pikselB = Convert.ToBoolean(pikseliB);
                                    polje.SetValue(pikseliB, 2);
                                }
                                break;
                            case 3:
                                {
                                    int pikseliR = pikseli.R % 2;
                                    bool pikselR = Convert.ToBoolean(pikseliR);
                                    polje.SetValue(pikseliR, 1);

                                    int pikseliG = pikseli.G % 2;
                                    bool pikselG = Convert.ToBoolean(pikseli.G);
                                    polje.SetValue(pikseliG, 0);

                                    BitArray b1 = new BitArray(8);

                                    for (int n = 7; n >= 0; n--)
                                    {
                                        bool bitovi = Convert.ToBoolean(polje.GetValue(n));
                                        b1.Set(n, bitovi);
                                    }
                                    byte bajt = new byte();
                                    bajt = PretvoriByte(b1);

                                    char slovo = Convert.ToChar(bajt);
                                    string tekst = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(slovo)});

                                    cijeli_tekst = cijeli_tekst + tekst;
                                    brojac = 0;
                                    brojac2++;
                                }
                                break;
                        }  
                    }
                }
            }
            textBox2.Text = cijeli_tekst;

            if(textBox2.TextLength == 0)
            {
                pictureBox4.Image= Properties.Resources.incorrect;
                label3.Text = "Skriveni tekst nije pronađen!";
                label9.Text = "Slika ne sadrži tekst"; 
            }
            else
            {
                pictureBox4.Image = Properties.Resources.correct;
                label3.Text = "Skriveni tekst je pronađen!";
                tekst(textBox2.TextLength);
            }
            label9.Visible = true; 
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            OpenFileDialog otvori = new OpenFileDialog();
            otvori.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (otvori.ShowDialog() == DialogResult.OK)
            {
                lokacija_slike = otvori.FileName.ToString();
                textBox1.Text = lokacija_slike;
                pictureBox1.ImageLocation = lokacija_slike;
                btnOtkrij.Visible = true;
                pictureBox2.Visible = true;
            }
            if (lokacija_slike != "")
            {
                dimenzije_slike(); 
            }
        }

        public void dimenzije_slike()
        {
            Bitmap slika = new Bitmap(textBox1.Text);

            label8.Text = slika.Width + " piksela";
            label7.Text = slika.Height + " piksela";

            Label labele; 

            for(int o= 5; o<=8; o++)
            {
                labele = (Label)this.Controls["Label" + o];
                labele.Visible = true;
            }
            label13.Visible = true;
        }
        public void provjera_teksta()
        {
            var tekst = textBox2.TextLength;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otkrivanje_teksta tekst = new Otkrivanje_teksta();
            tekst.Show(); 
        }

        byte PretvoriByte(BitArray bitovi)
        {
            byte[] bajt = new byte[1];
            bitovi.CopyTo(bajt,0);
            return bajt[0];
        }

        int pretvoriInt(BitArray bitArray)
        {
            int[] polje = new int[1];
            bitArray.CopyTo(polje, 0);
            return polje[0];
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog_spremi = new SaveFileDialog();
            dialog_spremi.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog_spremi.ShowDialog() == DialogResult.OK)
            {
                string lokacija = dialog_spremi.FileName;
                File.WriteAllText(lokacija, textBox2.Text);  
            }
        }

        public void tekst(int broj)
        {
            if (broj % 10 == 1)
            {
                label9.Text = "Tekst sadrži: " + textBox2.TextLength + " znak";
            }
            else if (broj % 10 == 0 || (broj % 10 > 4 && broj/10 != 0))
            {
                label9.Text = "Tekst sadrži: " + textBox2.TextLength + " znakova";
            }
            else
            {
                for (int i = 2; i <= 4; i++)
                {
                    label9.Text = "Tekst sadrži: " + textBox2.TextLength + " znaka";
                }
            }
        }
    }
}

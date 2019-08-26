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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

        private void btnSkrivanje_teksta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Skrivanje_teksta skrivanje_teksta = new Skrivanje_teksta();
            skrivanje_teksta.Show();
        }
    }
}

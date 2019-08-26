namespace Steganografija_zavrsni
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSkrivanje_teksta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsporedi = new System.Windows.Forms.Button();
            this.btnOtkrivanje_slike = new System.Windows.Forms.Button();
            this.btnSkrivanje_slike = new System.Windows.Forms.Button();
            this.btnOtkrivanje_teksta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkrivanje_teksta
            // 
            this.btnSkrivanje_teksta.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnSkrivanje_teksta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSkrivanje_teksta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkrivanje_teksta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkrivanje_teksta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkrivanje_teksta.ForeColor = System.Drawing.Color.White;
            this.btnSkrivanje_teksta.Location = new System.Drawing.Point(30, 154);
            this.btnSkrivanje_teksta.Name = "btnSkrivanje_teksta";
            this.btnSkrivanje_teksta.Size = new System.Drawing.Size(280, 55);
            this.btnSkrivanje_teksta.TabIndex = 1;
            this.btnSkrivanje_teksta.Text = "Skrivanje teksta";
            this.btnSkrivanje_teksta.UseVisualStyleBackColor = false;
            this.btnSkrivanje_teksta.Click += new System.EventHandler(this.btnSkrivanje_teksta_Click_1);
            this.btnSkrivanje_teksta.MouseEnter += new System.EventHandler(this.btnSkrivanje_teksta_MouseEnter);
            this.btnSkrivanje_teksta.MouseLeave += new System.EventHandler(this.btnSkrivanje_teksta_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnUsporedi);
            this.panel1.Controls.Add(this.btnOtkrivanje_slike);
            this.panel1.Controls.Add(this.btnSkrivanje_slike);
            this.panel1.Controls.Add(this.btnOtkrivanje_teksta);
            this.panel1.Controls.Add(this.btnSkrivanje_teksta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 718);
            this.panel1.TabIndex = 13;
            // 
            // btnUsporedi
            // 
            this.btnUsporedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsporedi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsporedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsporedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsporedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsporedi.ForeColor = System.Drawing.Color.White;
            this.btnUsporedi.Location = new System.Drawing.Point(30, 460);
            this.btnUsporedi.Name = "btnUsporedi";
            this.btnUsporedi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsporedi.Size = new System.Drawing.Size(281, 55);
            this.btnUsporedi.TabIndex = 5;
            this.btnUsporedi.Text = "Usporedi slike";
            this.btnUsporedi.UseVisualStyleBackColor = false;
            this.btnUsporedi.Click += new System.EventHandler(this.btnUsporedi_Click);
            this.btnUsporedi.MouseEnter += new System.EventHandler(this.btnUsporedi_MouseEnter);
            this.btnUsporedi.MouseLeave += new System.EventHandler(this.btnUsporedi_MouseLeave);
            // 
            // btnOtkrivanje_slike
            // 
            this.btnOtkrivanje_slike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOtkrivanje_slike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtkrivanje_slike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkrivanje_slike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtkrivanje_slike.ForeColor = System.Drawing.Color.White;
            this.btnOtkrivanje_slike.Location = new System.Drawing.Point(30, 383);
            this.btnOtkrivanje_slike.Name = "btnOtkrivanje_slike";
            this.btnOtkrivanje_slike.Size = new System.Drawing.Size(281, 55);
            this.btnOtkrivanje_slike.TabIndex = 4;
            this.btnOtkrivanje_slike.Text = "Otkrivanje slike iz slike";
            this.btnOtkrivanje_slike.UseVisualStyleBackColor = false;
            this.btnOtkrivanje_slike.Click += new System.EventHandler(this.btnOtkrivanje_slike_Click);
            this.btnOtkrivanje_slike.MouseEnter += new System.EventHandler(this.btnOtkrivanje_slike_MouseEnter);
            this.btnOtkrivanje_slike.MouseLeave += new System.EventHandler(this.btnOtkrivanje_slike_MouseLeave);
            // 
            // btnSkrivanje_slike
            // 
            this.btnSkrivanje_slike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSkrivanje_slike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkrivanje_slike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkrivanje_slike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkrivanje_slike.ForeColor = System.Drawing.Color.White;
            this.btnSkrivanje_slike.Location = new System.Drawing.Point(30, 306);
            this.btnSkrivanje_slike.Name = "btnSkrivanje_slike";
            this.btnSkrivanje_slike.Size = new System.Drawing.Size(281, 55);
            this.btnSkrivanje_slike.TabIndex = 3;
            this.btnSkrivanje_slike.Text = "Skrivanje slike";
            this.btnSkrivanje_slike.UseVisualStyleBackColor = false;
            this.btnSkrivanje_slike.Click += new System.EventHandler(this.btnSkrivanje_slike_Click);
            this.btnSkrivanje_slike.MouseEnter += new System.EventHandler(this.btnSkrivanje_slike_MouseEnter);
            this.btnSkrivanje_slike.MouseLeave += new System.EventHandler(this.btnSkrivanje_slike_MouseLeave);
            // 
            // btnOtkrivanje_teksta
            // 
            this.btnOtkrivanje_teksta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOtkrivanje_teksta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtkrivanje_teksta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkrivanje_teksta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtkrivanje_teksta.ForeColor = System.Drawing.Color.White;
            this.btnOtkrivanje_teksta.Location = new System.Drawing.Point(30, 230);
            this.btnOtkrivanje_teksta.Name = "btnOtkrivanje_teksta";
            this.btnOtkrivanje_teksta.Size = new System.Drawing.Size(281, 55);
            this.btnOtkrivanje_teksta.TabIndex = 2;
            this.btnOtkrivanje_teksta.Text = "Otkrivanje teksta";
            this.btnOtkrivanje_teksta.UseVisualStyleBackColor = false;
            this.btnOtkrivanje_teksta.Click += new System.EventHandler(this.btnOtkrivanje_teksta_Click);
            this.btnOtkrivanje_teksta.MouseEnter += new System.EventHandler(this.btnOtkrivanje_teksta_MouseEnter);
            this.btnOtkrivanje_teksta.MouseLeave += new System.EventHandler(this.btnOtkrivanje_teksta_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Steganografija_zavrsni.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(31, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Steganografija_zavrsni.Properties.Resources.pocetna;
            this.pictureBox2.Location = new System.Drawing.Point(334, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1113, 718);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1446, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StegoProgram";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSkrivanje_teksta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUsporedi;
        private System.Windows.Forms.Button btnOtkrivanje_slike;
        private System.Windows.Forms.Button btnSkrivanje_slike;
        private System.Windows.Forms.Button btnOtkrivanje_teksta;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


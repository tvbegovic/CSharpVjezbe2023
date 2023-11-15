namespace Zadatak2
{
    partial class Glavna
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgvPolaznici = new System.Windows.Forms.DataGridView();
            this.txtDatumUpisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(900, 127);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(900, 162);
            this.btnUcitaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(100, 28);
            this.btnUcitaj.TabIndex = 31;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(900, 202);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 28);
            this.btnSpremi.TabIndex = 32;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgvPolaznici
            // 
            this.dgvPolaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolaznici.Location = new System.Drawing.Point(40, 127);
            this.dgvPolaznici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPolaznici.Name = "dgvPolaznici";
            this.dgvPolaznici.RowHeadersWidth = 51;
            this.dgvPolaznici.Size = new System.Drawing.Size(829, 245);
            this.dgvPolaznici.TabIndex = 33;
            // 
            // txtDatumUpisa
            // 
            this.txtDatumUpisa.Location = new System.Drawing.Point(605, 48);
            this.txtDatumUpisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumUpisa.Name = "txtDatumUpisa";
            this.txtDatumUpisa.Size = new System.Drawing.Size(213, 22);
            this.txtDatumUpisa.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Datum  upisa:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(605, 11);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(213, 22);
            this.txtPrezime.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Prezime:";
            // 
            // txtDug
            // 
            this.txtDug.Location = new System.Drawing.Point(199, 79);
            this.txtDug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDug.Name = "txtDug";
            this.txtDug.Size = new System.Drawing.Size(213, 22);
            this.txtDug.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dug:";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(199, 47);
            this.txtOib.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(213, 22);
            this.txtOib.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "OIB:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(199, 15);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(213, 22);
            this.txtIme.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ime:";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 393);
            this.Controls.Add(this.txtDatumUpisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPolaznici);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnDodaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Glavna";
            this.Text = "Polaznici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolaznici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgvPolaznici;
		private System.Windows.Forms.TextBox txtDatumUpisa;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDug;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOib;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Label label1;
	}
}


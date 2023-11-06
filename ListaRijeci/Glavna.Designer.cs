namespace ListaRijeci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJednaRijec = new System.Windows.Forms.TextBox();
            this.btnDodajNaKraj = new System.Windows.Forms.Button();
            this.btnDodajNaPoziciju = new System.Windows.Forms.Button();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtViseRijeci = new System.Windows.Forms.TextBox();
            this.btnDodajVise = new System.Windows.Forms.Button();
            this.lstRijeci = new System.Windows.Forms.ListBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIsprazni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.btnDodajNaPoziciju);
            this.groupBox1.Controls.Add(this.btnDodajNaKraj);
            this.groupBox1.Controls.Add(this.txtJednaRijec);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jedna riječ";
            // 
            // txtJednaRijec
            // 
            this.txtJednaRijec.Location = new System.Drawing.Point(6, 21);
            this.txtJednaRijec.Name = "txtJednaRijec";
            this.txtJednaRijec.Size = new System.Drawing.Size(521, 22);
            this.txtJednaRijec.TabIndex = 0;
            // 
            // btnDodajNaKraj
            // 
            this.btnDodajNaKraj.Location = new System.Drawing.Point(6, 49);
            this.btnDodajNaKraj.Name = "btnDodajNaKraj";
            this.btnDodajNaKraj.Size = new System.Drawing.Size(166, 33);
            this.btnDodajNaKraj.TabIndex = 1;
            this.btnDodajNaKraj.Text = "Dodaj riječ na kraj";
            this.btnDodajNaKraj.UseVisualStyleBackColor = true;
            this.btnDodajNaKraj.Click += new System.EventHandler(this.btnDodajNaKraj_Click);
            // 
            // btnDodajNaPoziciju
            // 
            this.btnDodajNaPoziciju.Location = new System.Drawing.Point(189, 49);
            this.btnDodajNaPoziciju.Name = "btnDodajNaPoziciju";
            this.btnDodajNaPoziciju.Size = new System.Drawing.Size(166, 33);
            this.btnDodajNaPoziciju.TabIndex = 1;
            this.btnDodajNaPoziciju.Text = "Dodaj riječ na poziciju";
            this.btnDodajNaPoziciju.UseVisualStyleBackColor = true;
            this.btnDodajNaPoziciju.Click += new System.EventHandler(this.btnDodajNaPoziciju_Click);
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(377, 54);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(150, 22);
            this.txtPozicija.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajVise);
            this.groupBox2.Controls.Add(this.txtViseRijeci);
            this.groupBox2.Location = new System.Drawing.Point(21, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Više riječi";
            // 
            // txtViseRijeci
            // 
            this.txtViseRijeci.Location = new System.Drawing.Point(6, 21);
            this.txtViseRijeci.Multiline = true;
            this.txtViseRijeci.Name = "txtViseRijeci";
            this.txtViseRijeci.Size = new System.Drawing.Size(468, 97);
            this.txtViseRijeci.TabIndex = 0;
            // 
            // btnDodajVise
            // 
            this.btnDodajVise.Location = new System.Drawing.Point(495, 22);
            this.btnDodajVise.Name = "btnDodajVise";
            this.btnDodajVise.Size = new System.Drawing.Size(126, 36);
            this.btnDodajVise.TabIndex = 1;
            this.btnDodajVise.Text = "Dodaj";
            this.btnDodajVise.UseVisualStyleBackColor = true;
            this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
            // 
            // lstRijeci
            // 
            this.lstRijeci.FormattingEnabled = true;
            this.lstRijeci.ItemHeight = 16;
            this.lstRijeci.Location = new System.Drawing.Point(21, 283);
            this.lstRijeci.Name = "lstRijeci";
            this.lstRijeci.Size = new System.Drawing.Size(474, 212);
            this.lstRijeci.TabIndex = 2;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(516, 283);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(126, 41);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIsprazni
            // 
            this.btnIsprazni.Location = new System.Drawing.Point(516, 330);
            this.btnIsprazni.Name = "btnIsprazni";
            this.btnIsprazni.Size = new System.Drawing.Size(126, 41);
            this.btnIsprazni.TabIndex = 3;
            this.btnIsprazni.Text = "Isprazni listu";
            this.btnIsprazni.UseVisualStyleBackColor = true;
            this.btnIsprazni.Click += new System.EventHandler(this.btnIsprazni_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnIsprazni);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.lstRijeci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Glavna";
            this.Text = "Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJednaRijec;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Button btnDodajNaPoziciju;
        private System.Windows.Forms.Button btnDodajNaKraj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajVise;
        private System.Windows.Forms.TextBox txtViseRijeci;
        private System.Windows.Forms.ListBox lstRijeci;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIsprazni;
    }
}


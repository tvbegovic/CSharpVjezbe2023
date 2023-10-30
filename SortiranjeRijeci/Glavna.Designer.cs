namespace SortiranjeRijeci
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRijeci = new System.Windows.Forms.TextBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSortirano = new System.Windows.Forms.ListBox();
            this.btnSortirajOrder = new System.Windows.Forms.Button();
            this.btnSortirajSilazno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riječi:";
            // 
            // txtRijeci
            // 
            this.txtRijeci.Location = new System.Drawing.Point(139, 37);
            this.txtRijeci.Multiline = true;
            this.txtRijeci.Name = "txtRijeci";
            this.txtRijeci.Size = new System.Drawing.Size(461, 127);
            this.txtRijeci.TabIndex = 1;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(631, 37);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(136, 44);
            this.btnSortiraj.TabIndex = 2;
            this.btnSortiraj.Text = "Sortiraj (Sort)";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sortirani niz:";
            // 
            // lstSortirano
            // 
            this.lstSortirano.FormattingEnabled = true;
            this.lstSortirano.ItemHeight = 16;
            this.lstSortirano.Location = new System.Drawing.Point(139, 205);
            this.lstSortirano.Name = "lstSortirano";
            this.lstSortirano.Size = new System.Drawing.Size(319, 228);
            this.lstSortirano.TabIndex = 3;
            // 
            // btnSortirajOrder
            // 
            this.btnSortirajOrder.Location = new System.Drawing.Point(631, 96);
            this.btnSortirajOrder.Name = "btnSortirajOrder";
            this.btnSortirajOrder.Size = new System.Drawing.Size(136, 44);
            this.btnSortirajOrder.TabIndex = 2;
            this.btnSortirajOrder.Text = "Sortiraj (OrderBy)";
            this.btnSortirajOrder.UseVisualStyleBackColor = true;
            this.btnSortirajOrder.Click += new System.EventHandler(this.btnSortirajOrder_Click);
            // 
            // btnSortirajSilazno
            // 
            this.btnSortirajSilazno.Location = new System.Drawing.Point(631, 158);
            this.btnSortirajSilazno.Name = "btnSortirajSilazno";
            this.btnSortirajSilazno.Size = new System.Drawing.Size(136, 45);
            this.btnSortirajSilazno.TabIndex = 4;
            this.btnSortirajSilazno.Text = "Sortiraj silazno";
            this.btnSortirajSilazno.UseVisualStyleBackColor = true;
            this.btnSortirajSilazno.Click += new System.EventHandler(this.btnSortirajSilazno_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortirajSilazno);
            this.Controls.Add(this.lstSortirano);
            this.Controls.Add(this.btnSortirajOrder);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.txtRijeci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Sortiranje riječi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRijeci;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSortirano;
        private System.Windows.Forms.Button btnSortirajOrder;
        private System.Windows.Forms.Button btnSortirajSilazno;
    }
}


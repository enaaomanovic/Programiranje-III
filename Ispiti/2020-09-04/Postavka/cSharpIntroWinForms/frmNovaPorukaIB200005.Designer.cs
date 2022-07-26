namespace cSharpIntroWinForms
{
    partial class frmNovaPorukaIB200005
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbprimaoc = new System.Windows.Forms.TextBox();
            this.tbsadrzaj = new System.Windows.Forms.TextBox();
            this.pbslika = new System.Windows.Forms.PictureBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbslika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primalac";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sadrzaj";
            // 
            // tbprimaoc
            // 
            this.tbprimaoc.Location = new System.Drawing.Point(63, 91);
            this.tbprimaoc.Name = "tbprimaoc";
            this.tbprimaoc.Size = new System.Drawing.Size(210, 22);
            this.tbprimaoc.TabIndex = 3;
            // 
            // tbsadrzaj
            // 
            this.tbsadrzaj.Location = new System.Drawing.Point(63, 197);
            this.tbsadrzaj.Multiline = true;
            this.tbsadrzaj.Name = "tbsadrzaj";
            this.tbsadrzaj.Size = new System.Drawing.Size(210, 154);
            this.tbsadrzaj.TabIndex = 4;
            // 
            // pbslika
            // 
            this.pbslika.Location = new System.Drawing.Point(301, 91);
            this.pbslika.Name = "pbslika";
            this.pbslika.Size = new System.Drawing.Size(311, 260);
            this.pbslika.TabIndex = 5;
            this.pbslika.TabStop = false;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(536, 383);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 6;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            // 
            // frmNovaPorukaIB200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.pbslika);
            this.Controls.Add(this.tbsadrzaj);
            this.Controls.Add(this.tbprimaoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaPorukaIB200005";
            this.Text = "frmNovaPorukaIB200005";
            this.Load += new System.EventHandler(this.frmNovaPorukaIB200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbslika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbprimaoc;
        private System.Windows.Forms.TextBox tbsadrzaj;
        private System.Windows.Forms.PictureBox pbslika;
        private System.Windows.Forms.Button btnSpasi;
    }
}
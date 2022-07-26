namespace DLWMS.WinForms.IspitIB200005
{
    partial class frmNoviScanIspita200005
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpredmet = new System.Windows.Forms.ComboBox();
            this.tbnapomena = new System.Windows.Forms.TextBox();
            this.pbslika = new System.Windows.Forms.PictureBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.cbVaranje = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbslika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Napomena";
            // 
            // cmbpredmet
            // 
            this.cmbpredmet.FormattingEnabled = true;
            this.cmbpredmet.Location = new System.Drawing.Point(38, 53);
            this.cmbpredmet.Name = "cmbpredmet";
            this.cmbpredmet.Size = new System.Drawing.Size(121, 24);
            this.cmbpredmet.TabIndex = 4;
            this.cmbpredmet.SelectedIndexChanged += new System.EventHandler(this.cmbpredmet_SelectedIndexChanged);
            // 
            // tbnapomena
            // 
            this.tbnapomena.Location = new System.Drawing.Point(38, 160);
            this.tbnapomena.Multiline = true;
            this.tbnapomena.Name = "tbnapomena";
            this.tbnapomena.Size = new System.Drawing.Size(266, 215);
            this.tbnapomena.TabIndex = 5;
            this.tbnapomena.TextChanged += new System.EventHandler(this.tbnapomena_TextChanged);
            // 
            // pbslika
            // 
            this.pbslika.Location = new System.Drawing.Point(353, 53);
            this.pbslika.Name = "pbslika";
            this.pbslika.Size = new System.Drawing.Size(357, 322);
            this.pbslika.TabIndex = 6;
            this.pbslika.TabStop = false;
            this.pbslika.Click += new System.EventHandler(this.pbslika_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(634, 400);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // cbVaranje
            // 
            this.cbVaranje.AutoSize = true;
            this.cbVaranje.Location = new System.Drawing.Point(38, 400);
            this.cbVaranje.Name = "cbVaranje";
            this.cbVaranje.Size = new System.Drawing.Size(98, 21);
            this.cbVaranje.TabIndex = 8;
            this.cbVaranje.Text = "checkBox1";
            this.cbVaranje.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNoviScanIspita200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbVaranje);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.pbslika);
            this.Controls.Add(this.tbnapomena);
            this.Controls.Add(this.cmbpredmet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspita200005";
            this.Text = "frmNoviScanIspita200005";
            this.Load += new System.EventHandler(this.frmNoviScanIspita200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbslika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpredmet;
        private System.Windows.Forms.TextBox tbnapomena;
        private System.Windows.Forms.PictureBox pbslika;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.CheckBox cbVaranje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
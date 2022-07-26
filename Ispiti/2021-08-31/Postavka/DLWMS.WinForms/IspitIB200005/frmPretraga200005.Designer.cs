namespace DLWMS.WinForms.IspitIB200005
{
    partial class frmPretraga200005
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
            this.dgvpretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbimeprezime = new System.Windows.Forms.TextBox();
            this.lblnajbolji = new System.Windows.Forms.Label();
            this.lblprosjek = new System.Windows.Forms.Label();
            this.tbtekst = new System.Windows.Forms.TextBox();
            this.lblsuglasnici = new System.Windows.Forms.Label();
            this.lblznakovi = new System.Windows.Forms.Label();
            this.lblsamoglasnici = new System.Windows.Forms.Label();
            this.bznGnerisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpretraga
            // 
            this.dgvpretraga.AllowUserToAddRows = false;
            this.dgvpretraga.AllowUserToDeleteRows = false;
            this.dgvpretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmeti,
            this.BrojPolozenih,
            this.Prosjek,
            this.Column1});
            this.dgvpretraga.Location = new System.Drawing.Point(38, 77);
            this.dgvpretraga.Name = "dgvpretraga";
            this.dgvpretraga.ReadOnly = true;
            this.dgvpretraga.RowHeadersWidth = 51;
            this.dgvpretraga.RowTemplate.Height = 24;
            this.dgvpretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpretraga.Size = new System.Drawing.Size(711, 279);
            this.dgvpretraga.TabIndex = 0;
            this.dgvpretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            this.PolozeniPredmeti.HeaderText = "PolozeniPredmeti";
            this.PolozeniPredmeti.MinimumWidth = 6;
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            this.PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "BrojPolozenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Ispit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ime ili prezime";
            // 
            // tbimeprezime
            // 
            this.tbimeprezime.Location = new System.Drawing.Point(141, 27);
            this.tbimeprezime.Name = "tbimeprezime";
            this.tbimeprezime.Size = new System.Drawing.Size(608, 22);
            this.tbimeprezime.TabIndex = 2;
            this.tbimeprezime.TextChanged += new System.EventHandler(this.tbimeprezime_TextChanged);
            // 
            // lblnajbolji
            // 
            this.lblnajbolji.AutoSize = true;
            this.lblnajbolji.Location = new System.Drawing.Point(461, 383);
            this.lblnajbolji.Name = "lblnajbolji";
            this.lblnajbolji.Size = new System.Drawing.Size(46, 17);
            this.lblnajbolji.TabIndex = 3;
            this.lblnajbolji.Text = "label2";
            // 
            // lblprosjek
            // 
            this.lblprosjek.AutoSize = true;
            this.lblprosjek.Location = new System.Drawing.Point(38, 383);
            this.lblprosjek.Name = "lblprosjek";
            this.lblprosjek.Size = new System.Drawing.Size(46, 17);
            this.lblprosjek.TabIndex = 4;
            this.lblprosjek.Text = "label3";
            // 
            // tbtekst
            // 
            this.tbtekst.Location = new System.Drawing.Point(38, 464);
            this.tbtekst.MaxLength = 64767;
            this.tbtekst.Multiline = true;
            this.tbtekst.Name = "tbtekst";
            this.tbtekst.Size = new System.Drawing.Size(711, 125);
            this.tbtekst.TabIndex = 5;
            // 
            // lblsuglasnici
            // 
            this.lblsuglasnici.AutoSize = true;
            this.lblsuglasnici.Location = new System.Drawing.Point(38, 607);
            this.lblsuglasnici.Name = "lblsuglasnici";
            this.lblsuglasnici.Size = new System.Drawing.Size(46, 17);
            this.lblsuglasnici.TabIndex = 6;
            this.lblsuglasnici.Text = "label2";
            // 
            // lblznakovi
            // 
            this.lblznakovi.AutoSize = true;
            this.lblznakovi.Location = new System.Drawing.Point(35, 672);
            this.lblznakovi.Name = "lblznakovi";
            this.lblznakovi.Size = new System.Drawing.Size(46, 17);
            this.lblznakovi.TabIndex = 7;
            this.lblznakovi.Text = "label3";
            // 
            // lblsamoglasnici
            // 
            this.lblsamoglasnici.AutoSize = true;
            this.lblsamoglasnici.Location = new System.Drawing.Point(35, 637);
            this.lblsamoglasnici.Name = "lblsamoglasnici";
            this.lblsamoglasnici.Size = new System.Drawing.Size(46, 17);
            this.lblsamoglasnici.TabIndex = 8;
            this.lblsamoglasnici.Text = "label4";
            // 
            // bznGnerisi
            // 
            this.bznGnerisi.Location = new System.Drawing.Point(673, 637);
            this.bznGnerisi.Name = "bznGnerisi";
            this.bznGnerisi.Size = new System.Drawing.Size(75, 23);
            this.bznGnerisi.TabIndex = 9;
            this.bznGnerisi.Text = "Generisi";
            this.bznGnerisi.UseVisualStyleBackColor = true;
            this.bznGnerisi.Click += new System.EventHandler(this.bznGnerisi_Click);
            // 
            // frmPretraga200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 756);
            this.Controls.Add(this.bznGnerisi);
            this.Controls.Add(this.lblsamoglasnici);
            this.Controls.Add(this.lblznakovi);
            this.Controls.Add(this.lblsuglasnici);
            this.Controls.Add(this.tbtekst);
            this.Controls.Add(this.lblprosjek);
            this.Controls.Add(this.lblnajbolji);
            this.Controls.Add(this.tbimeprezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvpretraga);
            this.Name = "frmPretraga200005";
            this.Text = "frmPretraga200005";
            this.Load += new System.EventHandler(this.frmPretraga200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbimeprezime;
        private System.Windows.Forms.Label lblnajbolji;
        private System.Windows.Forms.Label lblprosjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox tbtekst;
        private System.Windows.Forms.Label lblsuglasnici;
        private System.Windows.Forms.Label lblznakovi;
        private System.Windows.Forms.Label lblsamoglasnici;
        private System.Windows.Forms.Button bznGnerisi;
    }
}
namespace DLWMS.WinForms.Forme
{
    partial class frmCovidTest200005
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
            this.dgvCovid = new System.Windows.Forms.DataGridView();
            this.lblStudent = new System.Windows.Forms.Label();
            this.blbDatum = new System.Windows.Forms.Label();
            this.lblRezlutati = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbNalaz = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblGenerisanje = new System.Windows.Forms.Label();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.tbgenerisanje = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.lblIzbrisi = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.cmbRezultati = new System.Windows.Forms.ComboBox();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCovid
            // 
            this.dgvCovid.AllowUserToAddRows = false;
            this.dgvCovid.AllowUserToDeleteRows = false;
            this.dgvCovid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCovid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvCovid.Location = new System.Drawing.Point(90, 125);
            this.dgvCovid.Name = "dgvCovid";
            this.dgvCovid.ReadOnly = true;
            this.dgvCovid.RowHeadersWidth = 51;
            this.dgvCovid.RowTemplate.Height = 24;
            this.dgvCovid.Size = new System.Drawing.Size(903, 337);
            this.dgvCovid.TabIndex = 0;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(90, 13);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(57, 17);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student";
            // 
            // blbDatum
            // 
            this.blbDatum.AutoSize = true;
            this.blbDatum.Location = new System.Drawing.Point(314, 13);
            this.blbDatum.Name = "blbDatum";
            this.blbDatum.Size = new System.Drawing.Size(111, 17);
            this.blbDatum.TabIndex = 2;
            this.blbDatum.Text = "Datum testiranja";
            // 
            // lblRezlutati
            // 
            this.lblRezlutati.AutoSize = true;
            this.lblRezlutati.Location = new System.Drawing.Point(495, 13);
            this.lblRezlutati.Name = "lblRezlutati";
            this.lblRezlutati.Size = new System.Drawing.Size(63, 17);
            this.lblRezlutati.TabIndex = 3;
            this.lblRezlutati.Text = "Rezlutati";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(272, 67);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // cbNalaz
            // 
            this.cbNalaz.AutoSize = true;
            this.cbNalaz.Location = new System.Drawing.Point(662, 67);
            this.cbNalaz.Name = "cbNalaz";
            this.cbNalaz.Size = new System.Drawing.Size(134, 21);
            this.cbNalaz.TabIndex = 7;
            this.cbNalaz.Text = "Nalaz dostavljen";
            this.cbNalaz.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(918, 65);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(93, 510);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(46, 17);
            this.lblBroj.TabIndex = 10;
            this.lblBroj.Text = "label5";
            // 
            // lblGenerisanje
            // 
            this.lblGenerisanje.AutoSize = true;
            this.lblGenerisanje.Location = new System.Drawing.Point(256, 482);
            this.lblGenerisanje.Name = "lblGenerisanje";
            this.lblGenerisanje.Size = new System.Drawing.Size(135, 17);
            this.lblGenerisanje.TabIndex = 11;
            this.lblGenerisanje.Text = "Generisanje testova";
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(259, 510);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(88, 17);
            this.lblBrojTestova.TabIndex = 12;
            this.lblBrojTestova.Text = "Broj Testova";
            // 
            // tbgenerisanje
            // 
            this.tbgenerisanje.Location = new System.Drawing.Point(352, 510);
            this.tbgenerisanje.Name = "tbgenerisanje";
            this.tbgenerisanje.Size = new System.Drawing.Size(100, 22);
            this.tbgenerisanje.TabIndex = 13;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(498, 508);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 14;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblIzbrisi
            // 
            this.lblIzbrisi.AutoSize = true;
            this.lblIzbrisi.Location = new System.Drawing.Point(633, 481);
            this.lblIzbrisi.Name = "lblIzbrisi";
            this.lblIzbrisi.Size = new System.Drawing.Size(94, 17);
            this.lblIzbrisi.TabIndex = 15;
            this.lblIzbrisi.Text = "Izbrisi testove";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(636, 508);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 16;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(836, 508);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 17;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(90, 65);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(121, 24);
            this.cmbStudenti.TabIndex = 18;
            this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbStudenti_SelectedIndexChanged);
            // 
            // cmbRezultati
            // 
            this.cmbRezultati.FormattingEnabled = true;
            this.cmbRezultati.Items.AddRange(new object[] {
            "Negativan",
            "Pozitivan"});
            this.cmbRezultati.Location = new System.Drawing.Point(498, 67);
            this.cmbRezultati.Name = "cmbRezultati";
            this.cmbRezultati.Size = new System.Drawing.Size(121, 24);
            this.cmbRezultati.TabIndex = 19;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultati";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.HeaderText = "NalazDostavljen";
            this.NalazDostavljen.MinimumWidth = 6;
            this.NalazDostavljen.Name = "NalazDostavljen";
            this.NalazDostavljen.ReadOnly = true;
            this.NalazDostavljen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NalazDostavljen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmCovidTest200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 612);
            this.Controls.Add(this.cmbRezultati);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.lblIzbrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.tbgenerisanje);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.lblGenerisanje);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNalaz);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblRezlutati);
            this.Controls.Add(this.blbDatum);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dgvCovid);
            this.Name = "frmCovidTest200005";
            this.Text = "frmCovidTest200005";
            this.Load += new System.EventHandler(this.frmCovidTest200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCovid;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label blbDatum;
        private System.Windows.Forms.Label lblRezlutati;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.CheckBox cbNalaz;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblGenerisanje;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.TextBox tbgenerisanje;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label lblIzbrisi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.ComboBox cmbRezultati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
    }
}
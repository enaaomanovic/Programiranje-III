namespace DLWMS.WinForms.Forme
{
    partial class frmStudenti
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.lblimeprezime = new System.Windows.Forms.Label();
            this.tbimeprezime = new System.Windows.Forms.TextBox();
            this.lblgodinastudija = new System.Windows.Forms.Label();
            this.lblaktivnost = new System.Windows.Forms.Label();
            this.cmbgodinastudija = new System.Windows.Forms.ComboBox();
            this.cmbaktivnost = new System.Windows.Forms.ComboBox();
            this.lblbrojstudenata = new System.Windows.Forms.Label();
            this.lblprosjek = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPotvrde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.GodinaStudija,
            this.Aktivan,
            this.Polozeni});
            this.dgvStudenti.Location = new System.Drawing.Point(16, 54);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(909, 331);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // Indeks
            // 
            this.Indeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.MinimumWidth = 6;
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            this.Spol.Width = 125;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.MinimumWidth = 6;
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            this.GodinaStudija.Width = 125;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 125;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            this.Polozeni.Width = 125;
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Location = new System.Drawing.Point(793, 16);
            this.btnNoviStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(129, 28);
            this.btnNoviStudent.TabIndex = 1;
            this.btnNoviStudent.Text = "Novi student";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.btnNoviStudent_Click);
            // 
            // lblimeprezime
            // 
            this.lblimeprezime.AutoSize = true;
            this.lblimeprezime.Location = new System.Drawing.Point(16, 16);
            this.lblimeprezime.Name = "lblimeprezime";
            this.lblimeprezime.Size = new System.Drawing.Size(91, 17);
            this.lblimeprezime.TabIndex = 2;
            this.lblimeprezime.Text = "Ime i prezime";
            // 
            // tbimeprezime
            // 
            this.tbimeprezime.Location = new System.Drawing.Point(113, 13);
            this.tbimeprezime.Name = "tbimeprezime";
            this.tbimeprezime.Size = new System.Drawing.Size(100, 22);
            this.tbimeprezime.TabIndex = 3;
            this.tbimeprezime.TextChanged += new System.EventHandler(this.tbimeprezime_TextChanged);
            // 
            // lblgodinastudija
            // 
            this.lblgodinastudija.AutoSize = true;
            this.lblgodinastudija.Location = new System.Drawing.Point(238, 14);
            this.lblgodinastudija.Name = "lblgodinastudija";
            this.lblgodinastudija.Size = new System.Drawing.Size(101, 17);
            this.lblgodinastudija.TabIndex = 4;
            this.lblgodinastudija.Text = "Godina Studija";
            // 
            // lblaktivnost
            // 
            this.lblaktivnost.AutoSize = true;
            this.lblaktivnost.Location = new System.Drawing.Point(507, 9);
            this.lblaktivnost.Name = "lblaktivnost";
            this.lblaktivnost.Size = new System.Drawing.Size(65, 17);
            this.lblaktivnost.TabIndex = 5;
            this.lblaktivnost.Text = "Aktivnost";
            // 
            // cmbgodinastudija
            // 
            this.cmbgodinastudija.FormattingEnabled = true;
            this.cmbgodinastudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbgodinastudija.Location = new System.Drawing.Point(355, 10);
            this.cmbgodinastudija.Name = "cmbgodinastudija";
            this.cmbgodinastudija.Size = new System.Drawing.Size(121, 24);
            this.cmbgodinastudija.TabIndex = 6;
            this.cmbgodinastudija.Text = "Svi";
            this.cmbgodinastudija.SelectedIndexChanged += new System.EventHandler(this.cmbgodinastudija_SelectedIndexChanged);
            // 
            // cmbaktivnost
            // 
            this.cmbaktivnost.FormattingEnabled = true;
            this.cmbaktivnost.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan",
            "Svi"});
            this.cmbaktivnost.Location = new System.Drawing.Point(590, 7);
            this.cmbaktivnost.Name = "cmbaktivnost";
            this.cmbaktivnost.Size = new System.Drawing.Size(121, 24);
            this.cmbaktivnost.TabIndex = 7;
            this.cmbaktivnost.Text = "Svi";
            this.cmbaktivnost.SelectedIndexChanged += new System.EventHandler(this.cmbaktivnost_SelectedIndexChanged);
            // 
            // lblbrojstudenata
            // 
            this.lblbrojstudenata.AutoSize = true;
            this.lblbrojstudenata.Location = new System.Drawing.Point(19, 414);
            this.lblbrojstudenata.Name = "lblbrojstudenata";
            this.lblbrojstudenata.Size = new System.Drawing.Size(100, 17);
            this.lblbrojstudenata.TabIndex = 8;
            this.lblbrojstudenata.Text = "Broj studenata";
            // 
            // lblprosjek
            // 
            this.lblprosjek.AutoSize = true;
            this.lblprosjek.Location = new System.Drawing.Point(22, 441);
            this.lblprosjek.Name = "lblprosjek";
            this.lblprosjek.Size = new System.Drawing.Size(55, 17);
            this.lblprosjek.TabIndex = 9;
            this.lblprosjek.Text = "Prosjek";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(846, 414);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 10;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(590, 413);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrde.TabIndex = 11;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 470);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.lblprosjek);
            this.Controls.Add(this.lblbrojstudenata);
            this.Controls.Add(this.cmbaktivnost);
            this.Controls.Add(this.cmbgodinastudija);
            this.Controls.Add(this.lblaktivnost);
            this.Controls.Add(this.lblgodinastudija);
            this.Controls.Add(this.tbimeprezime);
            this.Controls.Add(this.lblimeprezime);
            this.Controls.Add(this.btnNoviStudent);
            this.Controls.Add(this.dgvStudenti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.Label lblimeprezime;
        private System.Windows.Forms.TextBox tbimeprezime;
        private System.Windows.Forms.Label lblgodinastudija;
        private System.Windows.Forms.Label lblaktivnost;
        private System.Windows.Forms.ComboBox cmbgodinastudija;
        private System.Windows.Forms.ComboBox cmbaktivnost;
        private System.Windows.Forms.Label lblbrojstudenata;
        private System.Windows.Forms.Label lblprosjek;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnPotvrde;
    }
}
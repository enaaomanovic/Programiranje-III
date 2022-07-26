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
            this.lbOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.cmbOznaka = new System.Windows.Forms.ComboBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnZaCovid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // lbOd
            // 
            this.lbOd.AutoSize = true;
            this.lbOd.Location = new System.Drawing.Point(16, 13);
            this.lbOd.Name = "lbOd";
            this.lbOd.Size = new System.Drawing.Size(27, 17);
            this.lbOd.TabIndex = 2;
            this.lbOd.Text = "Od";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(208, 13);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(26, 17);
            this.lblDo.TabIndex = 3;
            this.lblDo.Text = "Do";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Location = new System.Drawing.Point(462, 13);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(53, 17);
            this.lblOcjena.TabIndex = 4;
            this.lblOcjena.Text = "Ocjena";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(19, 410);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(46, 17);
            this.lblBroj.TabIndex = 5;
            this.lblBroj.Text = "label4";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(19, 459);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(46, 17);
            this.lblProsjek.TabIndex = 6;
            this.lblProsjek.Text = "label5";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(49, 13);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(152, 22);
            this.dtpOd.TabIndex = 7;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(240, 9);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(156, 22);
            this.dtpDo.TabIndex = 8;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // cmbOznaka
            // 
            this.cmbOznaka.FormattingEnabled = true;
            this.cmbOznaka.Items.AddRange(new object[] {
            "<",
            ">",
            "=",
            ">=",
            "<="});
            this.cmbOznaka.Location = new System.Drawing.Point(521, 11);
            this.cmbOznaka.Name = "cmbOznaka";
            this.cmbOznaka.Size = new System.Drawing.Size(121, 24);
            this.cmbOznaka.TabIndex = 9;
            this.cmbOznaka.SelectedIndexChanged += new System.EventHandler(this.cmbOznaka_SelectedIndexChanged);
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjena.Location = new System.Drawing.Point(648, 10);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(121, 24);
            this.cmbOcjena.TabIndex = 10;
            this.cmbOcjena.SelectedIndexChanged += new System.EventHandler(this.cmbOcjena_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnZaCovid
            // 
            this.btnZaCovid.Location = new System.Drawing.Point(630, 430);
            this.btnZaCovid.Name = "btnZaCovid";
            this.btnZaCovid.Size = new System.Drawing.Size(75, 23);
            this.btnZaCovid.TabIndex = 11;
            this.btnZaCovid.Text = "ZaCovid";
            this.btnZaCovid.UseVisualStyleBackColor = true;
            this.btnZaCovid.Click += new System.EventHandler(this.btnZaCovid_Click);
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 488);
            this.Controls.Add(this.btnZaCovid);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.cmbOznaka);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lbOd);
            this.Controls.Add(this.dgvStudenti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.Label lbOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.ComboBox cmbOznaka;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnZaCovid;
    }
}
namespace cSharpIntroWinForms
{
    partial class frmPretragaIB200005
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
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.tbpredmet = new System.Windows.Forms.TextBox();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblprosjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Korisnik,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Column1});
            this.dgvPretraga.Location = new System.Drawing.Point(27, 91);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 24;
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(724, 262);
            this.dgvPretraga.TabIndex = 0;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Predmet";
            // 
            // tbpredmet
            // 
            this.tbpredmet.Location = new System.Drawing.Point(108, 42);
            this.tbpredmet.Name = "tbpredmet";
            this.tbpredmet.Size = new System.Drawing.Size(643, 22);
            this.tbpredmet.TabIndex = 2;
            this.tbpredmet.TextChanged += new System.EventHandler(this.tbpredmet_TextChanged);
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Poruke";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // lblprosjek
            // 
            this.lblprosjek.AutoSize = true;
            this.lblprosjek.Location = new System.Drawing.Point(27, 380);
            this.lblprosjek.Name = "lblprosjek";
            this.lblprosjek.Size = new System.Drawing.Size(46, 17);
            this.lblprosjek.TabIndex = 3;
            this.lblprosjek.Text = "label1";
            // 
            // frmPretragaIB200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblprosjek);
            this.Controls.Add(this.tbpredmet);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvPretraga);
            this.Name = "frmPretragaIB200005";
            this.Text = "frmPretragaIB200005";
            this.Load += new System.EventHandler(this.frmPretragaIB200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbpredmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label lblprosjek;
    }
}
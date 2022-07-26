namespace cSharpIntroWinForms
{
    partial class frmPorukeBrojIB200005
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
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkonekcija = new System.Windows.Forms.Label();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnprinatj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Column1});
            this.dgvPoruke.Location = new System.Drawing.Point(33, 74);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersWidth = 51;
            this.dgvPoruke.RowTemplate.Height = 24;
            this.dgvPoruke.Size = new System.Drawing.Size(732, 287);
            this.dgvPoruke.TabIndex = 0;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Brisi";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konekcija sa";
            // 
            // lblkonekcija
            // 
            this.lblkonekcija.AutoSize = true;
            this.lblkonekcija.Location = new System.Drawing.Point(169, 27);
            this.lblkonekcija.Name = "lblkonekcija";
            this.lblkonekcija.Size = new System.Drawing.Size(46, 17);
            this.lblkonekcija.TabIndex = 2;
            this.lblkonekcija.Text = "label2";
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(689, 27);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 3;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnprinatj
            // 
            this.btnprinatj.Location = new System.Drawing.Point(690, 388);
            this.btnprinatj.Name = "btnprinatj";
            this.btnprinatj.Size = new System.Drawing.Size(75, 23);
            this.btnprinatj.TabIndex = 4;
            this.btnprinatj.Text = "Printaj";
            this.btnprinatj.UseVisualStyleBackColor = true;
            // 
            // frmPorukeBrojIB200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprinatj);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.lblkonekcija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoruke);
            this.Name = "frmPorukeBrojIB200005";
            this.Text = "frmPorukeBrojIB200005";
            this.Load += new System.EventHandler(this.frmPorukeBrojIB200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkonekcija;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnprinatj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
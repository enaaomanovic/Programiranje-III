namespace DLWMS.WinForms.IspitIB200005
{
    partial class frmScanIspita200005
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
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SkeniranIspit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstudent = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.SkeniranIspit,
            this.Column1});
            this.dgvIspiti.Location = new System.Drawing.Point(55, 98);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.ReadOnly = true;
            this.dgvIspiti.RowHeadersWidth = 51;
            this.dgvIspiti.RowTemplate.Height = 24;
            this.dgvIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspiti.Size = new System.Drawing.Size(658, 298);
            this.dgvIspiti.TabIndex = 0;
            this.dgvIspiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellContentClick);
            this.dgvIspiti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellDoubleClick);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 125;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Varanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Varanje.Width = 125;
            // 
            // SkeniranIspit
            // 
            this.SkeniranIspit.DataPropertyName = "SkeniranIspit";
            this.SkeniranIspit.HeaderText = "SkeniranIspit";
            this.SkeniranIspit.MinimumWidth = 6;
            this.SkeniranIspit.Name = "SkeniranIspit";
            this.SkeniranIspit.ReadOnly = true;
            this.SkeniranIspit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SkeniranIspit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SkeniranIspit.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Briši";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PregledIspita za student";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Location = new System.Drawing.Point(218, 48);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(46, 17);
            this.lblstudent.TabIndex = 2;
            this.lblstudent.Text = "label2";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(637, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(637, 435);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmScanIspita200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 522);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblstudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIspiti);
            this.Name = "frmScanIspita200005";
            this.Text = "frmScanIspita200005";
            this.Load += new System.EventHandler(this.frmScanIspita200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn SkeniranIspit;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
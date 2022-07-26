namespace DLWMS.WinForms.Forme
{
    partial class frmPotvrde200005
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
            this.dgvStudetniPotvrde = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpotvrda = new System.Windows.Forms.TextBox();
            this.btnGeneriši = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudetniPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudetniPotvrde
            // 
            this.dgvStudetniPotvrde.AllowUserToAddRows = false;
            this.dgvStudetniPotvrde.AllowUserToDeleteRows = false;
            this.dgvStudetniPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudetniPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvStudetniPotvrde.Location = new System.Drawing.Point(57, 57);
            this.dgvStudetniPotvrde.Name = "dgvStudetniPotvrde";
            this.dgvStudetniPotvrde.ReadOnly = true;
            this.dgvStudetniPotvrde.RowHeadersWidth = 51;
            this.dgvStudetniPotvrde.RowTemplate.Height = 24;
            this.dgvStudetniPotvrde.Size = new System.Drawing.Size(764, 426);
            this.dgvStudetniPotvrde.TabIndex = 0;
            this.dgvStudetniPotvrde.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudetniPotvrde_CellContentClick);
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
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.MinimumWidth = 6;
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Izdata
            // 
            this.Izdata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.MinimumWidth = 6;
            this.Izdata.Name = "Izdata";
            this.Izdata.ReadOnly = true;
            this.Izdata.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbpotvrda
            // 
            this.tbpotvrda.Location = new System.Drawing.Point(57, 13);
            this.tbpotvrda.Multiline = true;
            this.tbpotvrda.Name = "tbpotvrda";
            this.tbpotvrda.Size = new System.Drawing.Size(137, 38);
            this.tbpotvrda.TabIndex = 1;
            // 
            // btnGeneriši
            // 
            this.btnGeneriši.Location = new System.Drawing.Point(248, 12);
            this.btnGeneriši.Name = "btnGeneriši";
            this.btnGeneriši.Size = new System.Drawing.Size(135, 39);
            this.btnGeneriši.TabIndex = 2;
            this.btnGeneriši.Text = "Generiši potvrde";
            this.btnGeneriši.UseVisualStyleBackColor = true;
            this.btnGeneriši.Click += new System.EventHandler(this.btnGeneriši_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(458, 11);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(156, 40);
            this.btnIzbriši.TabIndex = 3;
            this.btnIzbriši.Text = "Izbriši potvrde";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(700, 11);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(107, 40);
            this.btnSpasi.TabIndex = 4;
            this.btnSpasi.Text = "Spasi u fajl";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // frmPotvrde200005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnGeneriši);
            this.Controls.Add(this.tbpotvrda);
            this.Controls.Add(this.dgvStudetniPotvrde);
            this.Name = "frmPotvrde200005";
            this.Text = "frmPotvrde200005";
            this.Load += new System.EventHandler(this.frmPotvrde200005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudetniPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudetniPotvrde;
        private System.Windows.Forms.TextBox tbpotvrda;
        private System.Windows.Forms.Button btnGeneriši;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}
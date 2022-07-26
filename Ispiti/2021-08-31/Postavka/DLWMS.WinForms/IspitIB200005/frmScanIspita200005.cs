using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB200005
{
    
    public partial class frmScanIspita200005 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiStatistike200005 red;

        public frmScanIspita200005()
        {
            InitializeComponent();
            dgvIspiti.AutoGenerateColumns = false;
        }

        public frmScanIspita200005(StudentiStatistike200005 red):this()
        {
            this.red = red;
        }

        private void frmScanIspita200005_Load(object sender, EventArgs e)
        {
            lblstudent.Text = red.Student.ToString();
            Ucitaj();


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmNoviScanIspita200005(red);
            frm.ShowDialog();
            Ucitaj();

        }

        private void Ucitaj()
        {

            dgvIspiti.DataSource = null;


            var lista = red.Student.KorisniciIspitiScan;
            dgvIspiti.DataSource = lista;

        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("zelite li obrisati", "naslov", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var red = dgvIspiti.SelectedRows[0].DataBoundItem as KorisniciIspitiScan200005;
                    _baza.KorisniciIspitiScan.Remove(red);
                    _baza.SaveChanges();
                }
                Ucitaj();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {

            var lista = dgvIspiti.DataSource as List<KorisniciIspitiScan200005>;
            Form frm = new frmIzvjestaji(lista);
            frm.ShowDialog();
        }

        private void dgvIspiti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ispitscan = dgvIspiti.SelectedRows[0].DataBoundItem as KorisniciIspitiScan200005;
            Form frm = new frmNoviScanIspita200005(ispitscan);
            frm.ShowDialog();






        }
    }
}

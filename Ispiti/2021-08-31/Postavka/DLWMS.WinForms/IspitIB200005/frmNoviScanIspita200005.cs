using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNoviScanIspita200005 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiStatistike200005 red;
        private KorisniciIspitiScan200005 ispitscan;

        public frmNoviScanIspita200005()
        {
            InitializeComponent();
        }

        public frmNoviScanIspita200005(StudentiStatistike200005 red):this()
        {
            this.red = red;
        }

        public frmNoviScanIspita200005(KorisniciIspitiScan200005 ispitscan):this()
        {
            this.ispitscan = ispitscan;
        }

        private void frmNoviScanIspita200005_Load(object sender, EventArgs e)
        {

            UcitajPredmete();
            if (ispitscan != null)
            {
                tbnapomena.Text = ispitscan.Napomena;
                tbnapomena.Enabled = false;
                cmbpredmet.SelectedValue = ispitscan.Predmet.Id;
                cmbpredmet.Enabled = false;
                pbslika.Image = ImageHelper.FromByteToImage(ispitscan.SkeniranIspit);
                pbslika.Enabled = false;
                cbVaranje.Checked = ispitscan.Varanje;
                cbVaranje.Enabled = false;
                btnSpasi.Enabled = false;
            }
        }

       

        private void UcitajPredmete()
        {
            cmbpredmet.DataSource = _baza.Predmet.ToList();
            cmbpredmet.DisplayMember = "Naziv";
            cmbpredmet.ValueMember = "Id";
        }

        private void tbnapomena_TextChanged(object sender, EventArgs e)
        {
            Validator.ValidirajKontrolu(tbnapomena, errorProvider1, "obavezna vrijednost");

        }

        private void cmbpredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validator.ValidirajKontrolu(cmbpredmet, errorProvider1, "obavezna vrijednost");

        }

        private void pbslika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbslika.Image = Image.FromFile(openFileDialog1.FileName);

            }


        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(
            Validator.ValidirajKontrolu(tbnapomena, errorProvider1, "obavezna vrijednost") &&
            Validator.ValidirajKontrolu(cmbpredmet, errorProvider1, "obavezna vrijednost")&&
            Validator.ValidirajKontrolu(pbslika, errorProvider1, "obavezna vrijednost"))
            {
                var testni = new KorisniciIspitiScan200005()
                {

                    Predmet = cmbpredmet.SelectedItem as Predmet,
                    Napomena = tbnapomena.Text,
                    Varanje = cbVaranje.Checked,
                    SkeniranIspit = ImageHelper.FromImageToByte(pbslika.Image),

                };
                red.Student.KorisniciIspitiScan.Add(testni);
                _baza.SaveChanges();
                Close();
            }

            

        }
    }
}

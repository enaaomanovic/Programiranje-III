using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class frmPorukeBrojIB200005 : Form
    {
        private KorisniciPredmeti red;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public frmPorukeBrojIB200005()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmPorukeBrojIB200005(KorisniciPredmeti red):this()
        {
            this.red = red;
        }

        private void frmPorukeBrojIB200005_Load(object sender, EventArgs e)
        {
            lblkonekcija.Text = red.Korisnik.ToString();
            Ucitaj();
        }

        private void Ucitaj()
        {
            dgvPoruke.DataSource = null;
            var lista = konekcijaNaBazu.KorisniciPorukeIB200005.ToList();
            dgvPoruke.DataSource = lista;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            Form frm = new frmNovaPorukaIB200005(red);
            frm.ShowDialog();



        }
    }
}

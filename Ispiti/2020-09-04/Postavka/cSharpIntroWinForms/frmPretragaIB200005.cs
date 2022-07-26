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
    public partial class frmPretragaIB200005 : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;


        public frmPretragaIB200005()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;

        }

        private void frmPretragaIB200005_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void Ucitaj()
        {
            dgvPretraga.DataSource = null;

            var query = konekcijaNaBazu.KorisniciPredmeti.AsQueryable();
            if (!string.IsNullOrEmpty(tbpredmet.Text))
            {
                query = query.Where(x => x.Predmet.Naziv.ToLower().Contains(tbpredmet.Text.ToLower()));
            }

            var lista = query.ToList();
            dgvPretraga.DataSource = lista;
            var prosjek = lista.Average(x =>(double?) x.Ocjena) ?? 0;
            if (prosjek == null)
            {
                lblprosjek.Text = $"prosjek je 0";
            }
            else
            {
                lblprosjek.Text = $"prosjek je {prosjek}";

            }


        }

        private void tbpredmet_TextChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                var red = dgvPretraga.SelectedRows[0].DataBoundItem as KorisniciPredmeti;
                Form frm = new frmPorukeBrojIB200005(red);
                frm.ShowDialog();



            }
        }
    }
}

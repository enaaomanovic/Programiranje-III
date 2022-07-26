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
    public partial class frmPretraga200005 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPretraga200005()
        {
            InitializeComponent();
            dgvpretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga200005_Load(object sender, EventArgs e)
        {
            Ucitaj();

        }

        private void Ucitaj()
        {
            dgvpretraga.DataSource = null;

            var query = _baza.Studenti.AsQueryable();
            if (!string.IsNullOrEmpty(tbimeprezime.Text))
            {
                query = query.Where(x => (x.Ime + " " + x.Prezime).ToLower().Contains(tbimeprezime.Text.ToLower()));
            }

            var lista = query.Select(x => new StudentiStatistike200005()
            {
                Student = x,
                BrojPolozenih = x.StudentiPredmeti.Count(),
                Prosjek = x.StudentiPredmeti.Average(y => (double?)y.Ocjena) ?? 0,
                StudentiPredmeti = x.StudentiPredmeti

            }).ToList();
            dgvpretraga.DataSource = lista;

            double prosjek = lista.Where(x => x.Prosjek > 0).Average(x => (double?)x.Prosjek) ?? 0;

            lblprosjek.Text = $"prosjek je:{prosjek.ToString("0.00")}";
            var najbolji = lista.OrderByDescending(x => x.Prosjek).FirstOrDefault();
            if (najbolji == null)
            {
                lblnajbolji.Text = "NAJBOLJI JE:NOT SET";
            }
            else
                lblnajbolji.Text = $"NAJBOLJI JE:{najbolji.Student}";


        }

        private void tbimeprezime_TextChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dgvpretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var red = dgvpretraga.SelectedRows[0].DataBoundItem as StudentiStatistike200005;
                Form frm = new frmScanIspita200005(red);
                frm.ShowDialog();

            }

        }

        private async void bznGnerisi_Click(object sender, EventArgs e)
        {

            var brojacsamoglasnika = 0;
            var brojacsuglasinka = 0;
            var brojacznakova = 0;
            List<char> samoglasnici = new List<char>()
            {
                'a','e','i','o','u'
            };
            List<char> simbol = new List<char>()
            {
                '?','!','<','>','*'
            };

            var broj = tbtekst.Text.Length;
            var mala = tbtekst.Text.ToLower();
            await Task.Run(() => {

                for (int i = 0; i < broj; i++)
                {
                    if (mala[i] >= 'a' && mala[i] <= 'z')
                    {
                        if (samoglasnici.Contains(mala[i]))
                        {
                            brojacsamoglasnika++;
                        }
                        else
                        {
                            brojacsuglasinka++;
                        }

                    }
                    if (simbol.Contains(mala[i]))
                    {
                        brojacznakova++;
                    }

                }


            });
            
            lblsuglasnici.Text = $"suglasnici:{brojacsuglasinka}";
            lblsamoglasnici.Text = $"samoglasnici:{brojacsamoglasnika}";
            lblznakovi.Text = $"znak:{brojacznakova}";


        }
    }
}

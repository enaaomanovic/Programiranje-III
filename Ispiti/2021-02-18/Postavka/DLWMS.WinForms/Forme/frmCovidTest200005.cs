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

namespace DLWMS.WinForms.Forme
{

    public partial class frmCovidTest200005 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmCovidTest200005()
        {
            InitializeComponent();
            dgvCovid.AutoGenerateColumns = false;
        }
        private void UčitavanjeTestova()
        {
            dgvCovid.DataSource = null;
            var lista = _baza.StudentiCovidTestovi;
            var covid = lista.ToList();
            dgvCovid.DataSource = covid;


            lblBroj.Text = $"Broj testova:{covid.Count()}";






        }
        private void ucitavanjeImena()
        {
            var lista = _baza.Studenti;
            var primjer = lista.ToList();
            cmbStudenti.DataSource = primjer;
        }
        private void frmCovidTest200005_Load(object sender, EventArgs e)
        {
            UčitavanjeTestova();
            ucitavanjeImena();






        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var testirani = new StudentiCovidTestovi()
            {
                Student = cmbStudenti.SelectedItem as Student,
                Datum = dtpDatum.Value,
                NalazDostavljen = cbNalaz.Checked,
                Rezultati = cmbRezultati.Text

            };
            _baza.StudentiCovidTestovi.Add(testirani);
            _baza.SaveChanges();
            UčitavanjeTestova();


        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var lista = _baza.Studenti;
            var listaStudenata = lista.ToList();


            Random rand = new Random();

            int broj = int.Parse(tbgenerisanje.Text);
            for (int i = 0; i < broj; i++)
            {
                var test = new StudentiCovidTestovi()
                {
                    Student = listaStudenata[rand.Next(listaStudenata.Count())],
                    Datum = DateTime.Now,
                    NalazDostavljen = rand.Next(2) == 1,
                    Rezultati = rand.Next(2) == 1 ? "Pozitivan" : "Negativan"

                };


                _baza.StudentiCovidTestovi.Add(test);
                _baza.SaveChanges();


            }

            UčitavanjeTestova();

        }
    }
}

using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; 

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

       

        private void UcitajPodatkeOStudentima()
        {
            dgvStudenti.DataSource = null;
            if (string.IsNullOrEmpty(cmbOcjena.Text))
            {
                errorProvider1.SetError(cmbOcjena, Poruke.ObaveznaVrijednost);
               
                return;

            }
            errorProvider1.SetError(cmbOcjena, null);
            var query = _baza.Studenti.AsQueryable();
            
            var ocjene = int.Parse(cmbOcjena.Text);
            var Od = dtpOd.Value;
            var Do = dtpDo.Value;
            var novi = _baza.StudentiPredmeti.AsQueryable();
            double prosjek = 0;
           
            switch (cmbOznaka.Text)
            {
                case"<":
                    query = query.Where(x => x.StudentiPredmeti.Count(y => y.Ocjena < ocjene && y.Datum>Od && y.Datum<Do) > 0 );
                    novi = novi.Where(x => x.Ocjena < ocjene && x.Datum > Od && x.Datum < Do);

                    break;
                case">":
                    query = query.Where(x => x.StudentiPredmeti.Count(y => y.Ocjena > ocjene && y.Datum>Od && y.Datum<Do) > 0 );
                    novi = novi.Where(x => x.Ocjena > ocjene && x.Datum > Od && x.Datum < Do);
                    break;
                case"=":
                    query = query.Where(x => x.StudentiPredmeti.Count(y => y.Ocjena == ocjene && y.Datum>Od && y.Datum<Do) > 0 );
                    novi = novi.Where(x => x.Ocjena == ocjene && x.Datum > Od && x.Datum < Do);
                    break;
                case"<=":
                    query = query.Where(x => x.StudentiPredmeti.Count(y => y.Ocjena <= ocjene && y.Datum>Od && y.Datum<Do) > 0 );
                    novi = novi.Where(x => x.Ocjena <= ocjene && x.Datum > Od && x.Datum < Do);
                    break;
                case">=":
                    query = query.Where(x => x.StudentiPredmeti.Count(y => y.Ocjena >= ocjene && y.Datum>Od && y.Datum<Do) > 0 );
                    novi = novi.Where(x => x.Ocjena >= ocjene && x.Datum > Od && x.Datum < Do);
                    break;
      
               
            }
            var student = query.ToList();
            dgvStudenti.DataSource = student;

            var brojac = student.Count;
            lblBroj.Text = brojac.ToString();

            prosjek = novi.Average(x =>(double?) x.Ocjena)??0;
            lblProsjek.Text = prosjek.ToString();

        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void cmbOznaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnZaCovid_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmCovidTest200005());
        }
    }
}

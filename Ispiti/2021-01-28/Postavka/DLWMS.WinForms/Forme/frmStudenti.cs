using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima()
        {
            dgvStudenti.DataSource = null;
            var studenti = _baza.Studenti.AsQueryable();
            if (!string.IsNullOrEmpty(tbimeprezime.Text))
                studenti = studenti.Where(x => (x.Ime + x.Prezime).ToLower().Contains(tbimeprezime.Text.ToLower()));

            if(cmbgodinastudija.SelectedItem != null && cmbgodinastudija.Text != "Svi")
            {
                int godina = int.Parse(cmbgodinastudija.Text);
                studenti = studenti.Where(x => x.GodinaStudija == godina);
            }
            if (cmbaktivnost.Text == "Aktivan")
                studenti = studenti.Where(x => x.Aktivan);
           else  if(cmbaktivnost.Text == "Neaktivan")
                studenti = studenti.Where(x => x.Aktivan==false);
            var list = studenti.ToList();

            dgvStudenti.DataSource = list;

          //ako nema ocjena ne puca vraca null
            var prosjek = list.Average(x => x.stundetipredmeti.Average(y => (double?)y.Ocjena));
            if(prosjek== null)
            {
                lblprosjek.Text = "Prosjecna ocjena:0";
            }
            else
                lblprosjek.Text = $"Prosjek:{prosjek.ToString()}";
            var brojac = list.Count();
            lblbrojstudenata.Text = $" broj studenata:{brojac.ToString()}";

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

        private void tbimeprezime_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            if (string.IsNullOrEmpty(tbimeprezime.Text))
                err.SetError(tbimeprezime, Poruke.ObaveznaVrijednost);
            else
                err.SetError(tbimeprezime, null);

        }

        private void cmbgodinastudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();

        }

        private void cmbaktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var list = dgvStudenti.DataSource as List<Student>;
            Form frm = new frmIzvjestaji(list);
            PrikaziFormu(frm);
            
            



        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmPotvrde200005());
            
        }
    }
}

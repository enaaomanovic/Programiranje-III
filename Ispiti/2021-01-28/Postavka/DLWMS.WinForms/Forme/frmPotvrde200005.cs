using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmPotvrde200005 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPotvrde200005()
        {
            InitializeComponent();
            dgvStudetniPotvrde.AutoGenerateColumns=false;
        }
        private void Refresanje()
        {
            dgvStudetniPotvrde.DataSource = null;
            var potvrda = _baza.StudentiPotvrde;
            var list = potvrda.ToList();
            dgvStudetniPotvrde.DataSource = list;
        }

        private void frmPotvrde200005_Load(object sender, EventArgs e)
        {
            dgvStudetniPotvrde.DataSource = null;
            var potvrda = _baza.StudentiPotvrde;
            var list = potvrda.ToList();
            dgvStudetniPotvrde.DataSource = list;





        }

        private async void btnGeneriši_Click(object sender, EventArgs e)
        {
            var lista = _baza.Studenti;
            var listaStudenata = lista.ToList();

            var random = new Random();
            int brojPodataka = int.Parse(tbpotvrda.Text);
           await Task.Run(() =>//ako se dodaje vise podataka da program ne zamrzne
            {

                for (int i = 0; i < brojPodataka; i++)
                {
                    var potvrda = new StudentiPotvrde

                    {
                        Student = listaStudenata[random.Next(listaStudenata.Count())],
                        Datum = DateTime.Now,
                        Izdata = random.Next(2) == 1,
                        Svrha = $"Regulisanje_statusa_{i + 1}"



                    };

                    _baza.StudentiPotvrde.Add(potvrda);
                }
                _baza.SaveChanges();
            });
            Refresanje();
        }

        private void dgvStudetniPotvrde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnIzbriši_Click(object sender, EventArgs e)
        {
            



            if(MessageBox.Show("da li želite obrisati","naslov",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                await Task.Run(() =>
                {


                    var lista = _baza.StudentiPotvrde.ToList();
                    _baza.StudentiPotvrde.RemoveRange(lista);
                    _baza.SaveChanges();

                });
               
                
               
                Refresanje();
            }

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("potvrdeBrojIndeksa.csv"))
            {
                var lista = dgvStudetniPotvrde.DataSource as List<StudentiPotvrde>;
                foreach (var s in lista)
                {
                    sw.WriteLine(s.Student.ToString() + "," + s.Datum.ToString() + "," + s.Svrha + "," +(s.Izdata?"Da":"Ne"));

                }
                sw.Close();
            }



        }
    }
}

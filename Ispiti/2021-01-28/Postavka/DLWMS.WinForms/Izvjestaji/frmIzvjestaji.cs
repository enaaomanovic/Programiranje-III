using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> list;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<Student> list):this()
        {
            this.list = list;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rds = new ReportDataSource();
            var datatable = new dsStudenti.dtStudentiDataTable();
            var brojac = 0;
            //dsCOVID.dtCOVIDDataTable();
            foreach (var student in list)
            {

                var row = datatable.NewdtStudentiRow();

                row.RB = (++brojac).ToString();
                row.Indeks = student.Indeks;
                row.Ime = student.Ime;
                row.Prezime = student.Prezime;
                row.Godina = (student.GodinaStudija).ToString();
                row.Aktivan = student.Aktivan ? "Da" : "Ne";
                row.Spol = student.Spol.ToString();

                datatable.AdddtStudentiRow(row);

            }
            rds.Name = "Studenti";
            rds.Value = datatable;

            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();


        }
    }
}

using DLWMS.WinForms.IspitIB200005;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<KorisniciIspitiScan200005> lista;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<KorisniciIspitiScan200005> lista) : this()
        {
            this.lista = lista;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var datatable = new dsStudenti.dtStudentiDataTable();

            foreach (var s in lista)
            {
                var row = datatable.NewdtStudentiRow();
                row.Predmet = s.Predmet.Naziv;
                row.Napomena = s.Napomena;
                row.Varanje = s.Varanje?"Da":"Ne";



                datatable.AdddtStudentiRow(row);
            }
            rds.Name = "dsStudent";
            rds.Value = datatable;


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}

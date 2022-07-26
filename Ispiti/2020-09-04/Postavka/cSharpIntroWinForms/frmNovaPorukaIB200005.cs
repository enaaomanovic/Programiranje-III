using cSharpIntroWinForms.P10;
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
    public partial class frmNovaPorukaIB200005 : Form
    {
        private KorisniciPredmeti red;

        public frmNovaPorukaIB200005()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB200005(KorisniciPredmeti red)
        {
            this.red = red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNovaPorukaIB200005_Load(object sender, EventArgs e)
        {
            tbprimaoc.Text = red.Korisnik.ToString();
        }
    }
}

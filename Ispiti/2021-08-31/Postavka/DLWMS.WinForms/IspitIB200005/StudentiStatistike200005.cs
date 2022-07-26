using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB200005
{
    public class StudentiStatistike200005
    {


        public Student Student { get; set; }
        public string PolozeniPredmeti
        {
            get
            {
                return String.Join(";", StudentiPredmeti);

            }
        }
        public List<StudentiPredmeti> StudentiPredmeti { get; set; }

        public int BrojPolozenih { get; set; }
        public double Prosjek { get; set; }

    }
}

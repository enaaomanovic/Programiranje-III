using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms
{
    [Table("KorisniciPoruke")]

    public class KorisniciPorukeIB200005
    {
        public int Id { get; set; }

        public Korisnik Korisnik { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
        public string Sadrzaj { get; set; }


    }
}

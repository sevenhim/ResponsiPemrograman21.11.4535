using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4535
{
    public class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan()
        {

        }

        public Karyawan(string nama, string nik, int gajibulanan)
        {
            Nama= nama;
            NIK= nik;
            GajiBulanan= gajibulanan;
        }
    }
}

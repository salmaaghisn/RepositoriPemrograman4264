using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman4264
{
    class karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Kenaikan { get; set; }

        public karyawan(int nik, string nama, int gajiBulanan)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gajiBulanan < 0)
            {
                this.GajiBulanan = 0;
                Kenaikan = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gajiBulanan;
                Kenaikan = Convert.ToInt32((GajiBulanan * 1.1));
            }

        }
    }
}

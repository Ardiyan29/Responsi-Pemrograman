using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4275
{
    class Karyawan
    {
        private string NIK;
        private string Nama;
        private int GajiBulanan;

        public string nik
        {
            get { return NIK; }
            set { NIK = value; }
        }
        public string nama
        {
            get { return Nama; }
            set { Nama = value; }
        }
        public int gaji_bulanan
        {
            get { return GajiBulanan; }
            set { GajiBulanan = value; }
        }

        public Karyawan(string NIK, string Nama, int GajiBulanan)
        {
            this.NIK = NIK;
            this.Nama = Nama;
            this.GajiBulanan = GajiBulanan < 0 ? 0 : GajiBulanan;
        }

        public void tampilkanData()
        {
            Console.WriteLine("{0} {1}      {2}", NIK, Nama, GajiBulanan);
        }

        public void naikGaji()
        {
            int kenaikan;

            kenaikan = GajiBulanan * 110;
            GajiBulanan = kenaikan / 100;

        
        }
    }
}

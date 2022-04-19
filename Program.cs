using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4275
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 4000000);
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No Nik/Nama           Gaji Bulanan");
            Console.WriteLine("----------------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();
            Console.WriteLine();
            

            Console.WriteLine("asyik naik gaji 10%");

            karyawan1.naikGaji();
            karyawan2.naikGaji();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama           Gaji Bulanan");
            Console.WriteLine("----------------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();
            Console.ReadKey();

        }
    }
}

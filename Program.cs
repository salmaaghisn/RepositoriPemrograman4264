using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman4264
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan1 = new karyawan(123456, "Syafiya Naila", 3000000);
            karyawan karyawan2 = new karyawan(234567, "Habibie Ahmad", 2000000);
            karyawan karyawan3 = new karyawan(132456, "Satya Braga", -100000);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(" NO | \t NIK / NAMA \t\t | Gaji Bulanan\t |");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(" 1. | \t {0} {1} \t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | \t {0} {1} \t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | \t {0} {1} \t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\nAsikkkkk nih dapat kenaikan gaji 10%!!!\n");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(" NO | \t NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(" 1. | \t {0} {1} \t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.Kenaikan);
            Console.WriteLine(" 2. | \t {0} {1} \t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.Kenaikan);
            Console.WriteLine(" 3. | \t {0} {1} \t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.ReadKey();
        }
    }
}

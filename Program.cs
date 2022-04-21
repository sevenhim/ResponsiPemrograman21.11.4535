using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4535
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();

            karyawan1.NIK = "21.11.4535";
            karyawan1.Nama = "Difa";
            karyawan1.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.NIK = "21.11.4536";
            karyawan2.Nama = "Budi";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("\n");
            Console.WriteLine("----------PEMBAYARAN GAJI KARYAWAN-----------");
            Console.WriteLine("No. \tNIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("ASIIK NAIK GAJI 10%!! ");
            Console.WriteLine("\n");
            Console.WriteLine("------------KENAIKAN GAJI 10%---------------");
            Console.WriteLine("No. \tNIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
using System;

namespace ResponsiPemrograman2671
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();
            Karyawan karyawan2 = new Karyawan();

            karyawan.No = "1.";
            karyawan.Nik = 190302123;
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = 3000000;

            karyawan2.No = "2.";
            karyawan2.Nik = 190302124;
            karyawan2.Nama = "Jono";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No   NIK/Nama            Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            karyawan.Data();
            karyawan2.Data();

            Console.WriteLine("Kenaikan Gaji 10%");
            Console.WriteLine("No   NIK/Nama            Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();

            Console.ReadKey();

        }
    }
}

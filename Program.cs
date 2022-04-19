using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4387
{
    class ResponsiPemrograman4387
    {
        static void Main(string[] args)
        {
            //objek
            karyawan karyawan = new karyawan();
            karyawan karyawan1 = new karyawan();

            //nilai 
            karyawan.No = "1";
            karyawan.Nik = "190302123";
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = "3000000";

            Console.WriteLine("Asyik kenaikan gaji 10 persen!");

            karyawan1.No = "2";
            karyawan1.Nik = "190302124";
            karyawan1.Nama = "Jono";
            karyawan1.GajiBulanan = "2000000";

            //pemanggilan
            karyawan.Info();
            karyawan.Gaji();
            karyawan1.Info();
            karyawan1.Gaji();

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4387
{
    public class karyawan
    {
        //properties
        public string No { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }


        // methods
        public void Info()
        {
            
            Console.WriteLine("Informasi Karyawan");
            Console.WriteLine("------------------");
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Nik: {0}", Nik, Nama, GajiBulanan);
            Console.WriteLine("Nama: {0}", Nama, GajiBulanan);
            Console.WriteLine("Gaji Bulanan: {0}", GajiBulanan);

            Console.WriteLine("Informasi Karyawan");
            Console.WriteLine("------------------");
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Nik: {0}", Nik, Nama, GajiBulanan);
            Console.WriteLine("Nama: {0}", Nama, GajiBulanan);
            Console.WriteLine("Gaji Bulanan: {0}", GajiBulanan);
        }

        public void Gaji()
        {
            
            if (Gaji < 0)
            {
                this.GajiBulanan = 0;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            Console.WriteLine("Informasi Karyawan");
            Console.WriteLine("------------------");
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Nik: {0}", Nik, Nama, GajiBulanan);
            Console.WriteLine("Nama: {0}", Nama, GajiBulanan);
            Console.WriteLine("Gaji Bulanan: {0}", GajiBulanan);
        }
    }
}

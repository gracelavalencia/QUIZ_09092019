using System;
namespace QUIZ_09092019
{
    class BangunRuang
    {
        public void volume_balok()
        {
            int panjang, lebar, tinggi;
            Console.WriteLine("Menghitung Volume Balok");
            
            Console.Write("Masukkan nilai panjang: ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai lebar: ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Volume Balok adalah: "+panjang*lebar*tinggi);

            Console.WriteLine("------------------------");
        }
        public void volume_kubus()
        {
            int sisi;
            Console.WriteLine("Menghitung Volume Kubus");
            
            Console.Write("Masukkan nilai sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Volume Kubus adalah: "+sisi*sisi*sisi);

            Console.WriteLine("------------------------");
        }
    }
}
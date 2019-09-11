using System;
namespace QUIZ_09092019
{
    class BangunDatar
    {
        public void luas_persegi()
        {
            int sisi;
            Console.WriteLine("Menghitung Luas Persegi");
            
            Console.Write("Masukkan nilai sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas Persegi adalah: "+sisi*sisi);

            Console.WriteLine("------------------------");
        }
        public void luas_segitiga()
        {
            int alas, tinggi;
            Console.WriteLine("Menghitung Luas Segitiga");

            Console.Write("Masukkan nilai alas: ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas Segitiga adalah: "+alas*tinggi/2);

            Console.WriteLine("------------------------");
        }
        public void luas_lingkaran()
        {
            int rusuk;
            Console.WriteLine("Menghitung Luas Lingkaran");
            
            Console.Write("Masukkan nilai rusuk: ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas Lingkaran adalah: "+rusuk*rusuk*3.14);

            Console.WriteLine("------------------------");
        }
    }
}

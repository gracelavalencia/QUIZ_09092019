using System;

namespace QUIZ_09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();

            obj.luas_persegi();

            obj.luas_segitiga();

            obj.luas_lingkaran();

            BangunRuang objc = new BangunRuang();

            objc.volume_balok();

            objc.volume_kubus();

        }
    }
}

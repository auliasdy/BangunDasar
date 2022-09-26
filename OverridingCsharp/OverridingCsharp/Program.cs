using System;

namespace OverridingCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Bangun Datar=====");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Lingkaran");
            Console.Write("Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("=====Persegi=====");
                    Persegi persegi = new Persegi();
                    Console.Write("Masukkan Sisi : ");
                    persegi.sisi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Persegi : {0}", persegi.luas());
                    Console.WriteLine("Keliling Persegi : {0}", persegi.keliling());
                    break;

                case 2:
                    Console.WriteLine("=====Segitiga=====");
                    Segitiga segitiga = new Segitiga();
                    Console.Write("Masukkan Alas : ");
                    segitiga.alas = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : ");
                    segitiga.tinggi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Segitiga : {0}", segitiga.luas());
                    break;

                case 3:
                    Console.WriteLine("=====Lingkaran=====");
                    Lingkaran lingkaran = new Lingkaran();
                    Console.Write("Masukkan Jari-Jari : ");
                    lingkaran.jari = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Lingkaran : {0}", lingkaran.luas());
                    Console.WriteLine("Keliling Lingkaran : {0}", lingkaran.keliling());
                    break;
            }
        }
        public abstract class BangunDatar
        {
            public double _hitung;
            public double Hitung
            {
                get { return _hitung; }
                set { _hitung = value; }
            }
            public abstract double luas();
            public abstract double keliling();
        }
        class Persegi : BangunDatar
        {
            private double s;
            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
            public override double luas()
            {
                _hitung = s * s;
                return _hitung;
            }
            public override double keliling()
            {
                _hitung = s * 4;
                return _hitung;
            }
        }
        class Segitiga : BangunDatar
        {
            private float a, t;
            public float alas
            {
                get { return a; }
                set
                {
                    a = value;
                }
            }
            public float tinggi
            {
                get { return t; }
                set
                {
                    t = value;
                }
            }
            public override double luas()
            {
                _hitung = (a * t) / 2;
                return _hitung;
            }
            public override double keliling()
            {
                throw new NotImplementedException();
            }
        }
        class Lingkaran : BangunDatar
        {
            private double r;
            public double jari
            {
                get { return r; }
                set
                {
                    r = value;
                }
            }
            public override double luas()
            {
                _hitung = 3.14 * r * r;
                return _hitung;
            }
            public override double keliling()
            {
                float _hitung = (float)(2 * Math.PI * r);
                return _hitung;
            }
        }
    }
}

using System;

namespace PolymorphismeCsharp
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
        public class Persegi : BangunDatar
        {
            private double s;

            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
            public Persegi()
            {
                this.sisi = sisi;
            }
            public override double luas()
            {
                return this.sisi * this.sisi;
            }
            public override double keliling()
            {
                return this.sisi * 4;
            }
        }
        public class Segitiga : BangunDatar
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
            public Segitiga()
            {
                this.alas = alas;
                this.tinggi = tinggi;
            }
            public override double luas()
            {
                return this.alas * this.tinggi / 2;
            }
            public override double keliling()
            {
                throw new NotImplementedException();
            }
        }
        public class Lingkaran : BangunDatar
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
            public Lingkaran()
            {
                this.jari = r;
            }
            public override double luas()
            {
                return (float)(Math.PI * r * r);
            }
            public override double keliling()
            {
                return (float)(2 * Math.PI * r);
            }
        }
    }
}

class BangunDatar:
    def luas(self):
        print("Menghitung Luas Bangun Datar")
    def keliling(self):
        print("Menghitung Keliling Bangun Datar")

class Persegi(BangunDatar):
    def sisi(self):
        pass

class Segitiga(BangunDatar):
    def alas(self):
        pass
    def tinggi(self):
        pass

class Lingkaran(BangunDatar):
    def r(self):
        pass

class Main():
  
  def menu():
    ProgramHitung = BangunDatar()
    ProgramHitung.luas()
    ProgramHitung.keliling()
    print("\n\nInheritance Program")
    print("1. Persegi")
    print("2. Segitiga")
    print("3. Lingkaran")
    print("4. Exit")
    

  menu()
  pilihan = int(input("\nPilih Menu: "))

  while pilihan != 5:
    if pilihan == 1:
     persegi = Persegi()
     print("Menghitung Luas dan Keliling Persegi")
     persegi.sisi = int(input("Masukkan Sisi: ")) 
     persegi.luas()
     persegi.keliling()
     break
    
    elif pilihan == 2:
     lingkaran = Lingkaran()
     print("Menghitung Luas dan Keliling Lingkaran")
     lingkaran.r = int(input("Masukkan Jari-jari: "))
     lingkaran.luas()
     lingkaran.keliling()
     break

    
    elif pilihan == 3:
     segitiga = Segitiga()
     print("Menghitung Luas Segitiga")
     segitiga.alas = int(input("Masukkan Alas: "))
     segitiga.tinggi = int(input("Masukkan Tinggi: "))
     segitiga.luas()
     break

    else:
      print("EROR!")

    menu()

  print("Terima Kasih telah menggunakan program!")

class BangunDatar():
  def luas(self):
    print("Menghitung Luas bangun datar")

  def keliling(self):
    print("Menghitung Keliling bangun datar")

class Persegi(BangunDatar):
  def _init_(self, sisi=0):
    self.sisi = sisi

  def luas(self):
    print("Luas Persegi: ", self.sisi * self.sisi)

  def keliling(self):
    print("Keliling Persegi: ", 4 * self.sisi)

class Segitiga(BangunDatar):
  def _init_(self, alas=0, tinggi=0, s1=0, s2=0):
    self.alas = alas
    self.tinggi = tinggi
    self.s1 = s1
    self.s2 = s2

  def luas(self):
    print("Luas Segitiga: ", 1/2 * self.alas * self.tinggi)

  def keliling(self):
      print("Keliling Segitiga : ", self.alas + self.s1 + self.s2)

class Lingkaran(BangunDatar):
  
  def _init_(self, r=0):
    self.r = r

  def luas(self):
    print("Luas Lingkaran: ", 3.14 * self.r ** 2)

  def keliling(self): 
    print("Keliling Lingkaran: ", 2 * 3.14 * self.r)

class Main():
  
  def menu():
    print("\n\nOverriding Program")
    print("1. Persegi")
    print("2. Lingkaran")
    print("3. Segitiga")
    print("4. Exit")

  menu()
  pilihan = int(input("Masukkan menu yang anda inginkan (1-4) : "))

  while pilihan != 5:
    if pilihan == 1:
     persegi = Persegi()
     print("\nMenghitung Luas dan Keliling Persegi")
     persegi.sisi = int(input("s = ")) 
     persegi.luas()
     persegi.keliling()
    
    elif pilihan == 2:
     lingkaran = Lingkaran()
     print("Menghitung Luas dan Keliling Lingkaran")
     lingkaran.r = int(input("r = "))
     lingkaran.luas()
     lingkaran.keliling()
   
    elif pilihan == 3:
     segitiga = Segitiga()
     print("Menghitung Luas Segitiga")
     segitiga.alas = int(input("a = "))
     segitiga.tinggi = int(input("t = "))
     segitiga.s1 = int(input("sisi 1 = "))
     segitiga.s2 = int(input("sisi 2 = "))
     segitiga.luas()
     segitiga.keliling()

    else:
      print("EROR!")

    menu()
    pilihan = int(input("\nMasukkan menu yang anda inginkan (1-4) : "))

using System;

namespace consoleAap
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERATÖRLER

            // Aritmetik Operatörler
            {
                var a = 10;
                var b = 3;
                var c = 2;

                // " a++ = a+1" şeklinde de yazılabilir.
                // " a-- = a-1" şeklinde de yazılabilir.

                var sonuc1 = a + b;
                var sonuc2 = a - b;
                var sonuc3 = a * b;
                var sonuc4 = a / b;
                var sonuc5 = (a + b) * c;
                var sonuc6 = a % b;
                var sonuc7 = 14 % 2;
                var sonuc = ++a;

                System.Console.WriteLine(sonuc1);
                System.Console.WriteLine(sonuc2);
                System.Console.WriteLine(sonuc3);
                System.Console.WriteLine(sonuc4);
                System.Console.WriteLine(sonuc5);
                System.Console.WriteLine(sonuc6);
                System.Console.WriteLine(sonuc7);
                System.Console.WriteLine(sonuc);
            }

            // Aritmetik Operatör Uygulamaları

            // a = 10 , b = 5 , c = 20 ise c - a farkının b katı kaçtır?
            {
                var a = 10;
                var b = 5;
                var c = 20;
                var sonuc = (c - a) * b;
                System.Console.WriteLine(sonuc);
            }

            // int? a = 50 ; int b = 20 ; ise a + b değerini hesaplayınız.
            {
                int? a = null;
                int? b = 20;
                var sonuc = (a ?? 0) + b;
                System.Console.WriteLine(sonuc);
            }

            // a= 10 , b = 20 ise a=b--; atamasından sonra a ve b değerleri kaçtır?
            {
                var a = 10;
                var b = 20;
                a = b--;
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
            }

            // Klavyeden girilen bir sayının tek / çift kontrolünü yapınız.
            {
                System.Console.Write("Bir sayı giriniz: ");
                int sayi = int.Parse(System.Console.ReadLine() ?? "0");
                var sonuc = sayi % 2;
                System.Console.WriteLine(sonuc); // Sonuç 1 ise "Tek" , 0 ise "Çift" olarak ekrana yazdırılacaktır.

                // Atama Operatörü
                var a = 5;
                var b = 10;

                a += b; // a = a + b
                a += 5; // a = a + 5
                a -= 5; // a = a - 5
                a -= b; // a = a - b
                a *= b; // a = a * b
                a /= b; // a = a / b

                // Math
                double mathSonuc;

                mathSonuc = Math.Pow(2, 3); // 2 üzeri 3
                mathSonuc = Math.Sqrt(25); // 25'in karekökü
                mathSonuc = Math.Abs(-10); // -10'un mutlak değeri
                mathSonuc = Math.Round(4.5); // 4.5'i en yakın tam sayıya yuvarlar
                mathSonuc = Math.Ceiling(4.1); // 4.1'i yukarı yuvarlar
                mathSonuc = Math.Floor(4.9); // 4.9'u aşağı yuvarlar
                mathSonuc = Math.Max(10, 20); // 10 ve 20'nin maksimumu
                mathSonuc = Math.Min(10, 20); // 10 ve 20'nin minimumu

                Console.WriteLine(mathSonuc);
            }

            // Karşılaştırma Operatörleri
            {
                int a = 6, b = 6, c = 10, d = 3;
                string username = "sadikturan";
                string password = "1234";

                var sonuc = (a == b); // true
                sonuc = (c == d); // false
                sonuc = (username == "sadikturan"); // true
                sonuc = (password == "12345"); // false

                sonuc = (a != b); // false
                sonuc = (a > c); // false
                sonuc = (a < c); // true
                sonuc = (a >= b); // true

                // Ternary Operatör 
                var sonuc2 = (a > b) ? "a büyüktür" : (a == b ? "a = b" : "b büyüktür");

                Console.WriteLine(sonuc);
                Console.WriteLine(sonuc2);
            }

            // Karşılaştırma Operatör Uygulamaları

            // 1. Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.
            {
                Console.Write("Yaşınızı giriniz: ");
                var yas = Convert.ToInt32(Console.ReadLine());

                var sonuc = (yas >= 18) ? "Oy kullanabilir" : "Oy kullanamaz";
                Console.WriteLine(sonuc);
            }

            // 2. Girilen bir sayının işaretni kontrol ediniz.
            {
                Console.Write("Bir sayı giriniz: ");
                var sayi = Convert.ToInt32(Console.ReadLine());

                var sonuc = (sayi > 0) ? "Pozitif" : (sayi < 0) ? "Negatif" : "Sıfır";
                Console.WriteLine(sonuc);
            }

            // 3. Girilen bir sayının tek/çift durumunu kontrol ediniz.
            {
                Console.Write("Bir sayı giriniz: ");
                var sayi = Convert.ToInt32(Console.ReadLine());

                var sonuc = (sayi % 2 == 0) ? "Sayı Çifttir" : "Sayı Tektir";
                Console.WriteLine(sonuc);
            }

            // Mantıksal Operatörler
            {
                var a = true;
                var b = true;
                var c = false;
                var d = false;

                // 1- ve - &&
                var sonuc = (a && b);
                sonuc = (a && c);
                sonuc = (c && d);

                //2- Veya - ||
                sonuc = (a || b);
                sonuc = (c || b);
                sonuc = (c || d);

                //3-- Değil - !
                sonuc = !a;
                Console.WriteLine(sonuc);
            }

            // Mantıksal Operatör Uygulamaları

            // 1- Yaşı 18'den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.
            {
                int yas = 17;
                bool veli_izni = false;

                bool yas_izni = (yas >= 18);
                bool veli_kontrol = (veli_izni == true);

                var sonuc = (yas_izni || veli_kontrol) ? "Çalışabilir" : "Çalışamaz";
                Console.WriteLine(sonuc);
            }

            //2- Ders notu 50-100 arasındaysa geçti değilse kaldı bilgisini yazdırınız.
            {
                int not = 50;

                bool kosul1 = (not >= 50);
                bool kosul2 = (not <= 100);
                var sonuc1 = (kosul1 && kosul2) ? "Geçti" : "Kaldı";
                Console.WriteLine(sonuc1);
            }

            // 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz. Sigara kullanamamma koşulunu da ekleyiniz.
            {
                int ortalama = 70;
                int zayif = 1;
                var sonuc2 = (ortalama >= 70 && zayif == 0) ? "Teşekkür Belgesi Alabilir" : "Teşekkür Belgesi Alamaz";
                Console.WriteLine(sonuc2);
            }

            // 4- İşe girmek için en az önlisans ya da lisans mezunu olma duruunu kontrol ediniz.Sigara kullanmama koşulu.
            {
                string egitim = "Lisans";
                bool sigara = false;

                var sonuc3 = ((egitim == "Önlisans" || egitim == "Lisans") && (!sigara)) ? "İşe girebilir" : "İşe giremez";
                Console.WriteLine(sonuc3);
            }

            // 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım.
            {
                string email = "islielanur1@gmail.com";
                string username = "islielanur1";
                string password = "123456";

                var sonuc4 = ((email == "islielanur1@gmail.com" || username == "islielanur1") && password == "123456") ? "Giriş Yapabilir" : "Giriş Yapılamaz";
                Console.WriteLine(sonuc4);
            }
        }
    }
}

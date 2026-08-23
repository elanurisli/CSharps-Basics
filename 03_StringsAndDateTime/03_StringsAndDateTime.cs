namespace consoleAap
{
    public class StringsAndDateTimeNote
    {
        public static void Notlar()
        {
            /*
                Strings: Karakter dizileri - reference => null
            */

            Console.Write("ad: ");
            var ad = Console.ReadLine();

            Console.Write("soyad: ");
            var soyad = Console.ReadLine();

            Console.Write("yaş: ");
            var yas = Console.ReadLine();

            // string concat (birleştirme işlemi)
            // string mesaj = ad + " " + soyad + " adlı kişi "+ yas+ " yaşındadır.";

            // string interpolation (string birleştirme)
            string mesaj2 = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";
            Console.WriteLine(mesaj2);

            string mesaj = "Ahmet turan isimli kişi 20 yaşındadır.";

            var sonuc1 = mesaj.Length;
            var sonuc2 = mesaj.ToLower();             // toLower() => tüm karakterleri küçük harfe çevir
            var sonuc3 = mesaj.ToUpper();             // toUpper() => tüm karakterleri büyük harfe çevir
            var sonuc4 = mesaj.Trim();                // trim() => baştaki ve sondaki boşlukları siler
            var sonuc5 = mesaj.Split(' ')[0];         // split() => boşluk karakterine göre ayırır ve diziye atar
            var sonuc6 = mesaj[3];                    // index => 3. karakteri verir
            var sonuc7 = mesaj.StartsWith("Ahmet");   // startsWith() => mesajın başında Ahmet var mı? true/false
            var sonuc8 = mesaj.EndsWith("dır.");      // endsWith() => mesajın sonunda dır. var mı? true/false
            var sonuc9 = mesaj.Contains("ela");       // contains() => mesajın içinde turan var mı? true/false (arama yapar)
            var sonuc10 = mesaj.IndexOf("ahmet");     // indexOf() => ahmet kelimesinin başladığı indexi verir
            var sonuc11 = mesaj.Substring(3, 7);      // substring() => 3. indexden başla ve 7 karakter al

            Console.WriteLine(sonuc11); // length => karakter sayısını verir

            /*
               Strring Uygulamaları
            */
            string kursAdi = ".NET 7 ile C# Programlama Dili";

            //1- Kaç karaktere sahiptir?:
            var u_sonuc1 = kursAdi.Length;

            //2- Tüm karakterleri küçük harfe çevir:
            var u_sonuc2 = kursAdi.ToLower();

            //3- '.' ile mi başlamaktadır?:
            var u_sonuc3 = kursAdi.StartsWith(".");

            //4- String "C#" ifadesi geçiyor mu?:
            var u_sonuc4 = kursAdi.Contains("C#");

            //5 - "C#" ifadesi kaçıncı indexte geçiyor?:
            var u_sonuc5 = kursAdi.IndexOf("C#");

            //6- 'Dili' kelimesi yerine 'Dersleri' yazınız.:
            var u_sonuc6 = kursAdi.Replace("Dili", "Dersleri");

            System.Console.WriteLine(u_sonuc1);
            System.Console.WriteLine(u_sonuc2);
            System.Console.WriteLine(u_sonuc3);
            System.Console.WriteLine(u_sonuc4);
            System.Console.WriteLine(u_sonuc5);
            System.Console.WriteLine(u_sonuc6);

            // REPLACE() => bir karakteri veya kelimeyi başka bir karakter veya kelime ile değiştirmek için kullanılır.

            /*
               Data Time
            */
            var simdi = DateTime.Now;

            Console.WriteLine($"Şu anki tarih ve saat: {simdi}");
            System.Console.WriteLine(simdi.Year); // yıl
            System.Console.WriteLine(simdi.Month); // ay
            System.Console.WriteLine(simdi.Day); // gün
            System.Console.WriteLine(simdi.Hour); // saat
            System.Console.WriteLine(simdi.Minute); // dakika
            System.Console.WriteLine(simdi.Second); // saniye

            DateTime dt = new DateTime(2023, 6, 15); // 15 Haziran 2023
            DateTime dt2 = dt.AddYears(2); // 15 Haziran 2025
            DateTime dt3 = dt.AddHours(3); // 15 Haziran 2023, 3 saat sonra

            System.Console.WriteLine(dt.Year);
            System.Console.WriteLine(dt2.Year);
            System.Console.WriteLine(dt3.Hour);

            var fark = simdi - dt; // simdi ile dt arasındaki farkı verir
            System.Console.WriteLine(fark.TotalDays); // toplam gün sayısı
        }
    }
}
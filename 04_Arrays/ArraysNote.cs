namespace consoleAap
{
    class ArraysNote
    {
        public static void Notlar()
        {
            // Array (Diziler)
            var kursAdi = ".net 7 ile c# programlama dersleri".Split(' ');

            // string[] isimler = new string[5];

            // isimler[0] = "Ahmet";
            // isimler[1] = "Mehmet";
            // isimler[2] = "Elanur";
            // isimler[3] = "Ali";
            // isimler[4] = "Elif";

            string[] isimler = { "Ahmet", "Mehmet", "Elanur", "Ali", "Elif" };

            // int[] numaralar = new int[5];

            // numaralar[0] = 100;
            // numaralar[1] = 200;
            // numaralar[2] = 300;
            // numaralar[3] = 400;
            // numaralar[4] = 500;

            int[] numaralar = { 100, 200, 300, 400, 500 };

            Console.WriteLine($"{numaralar[0]} numarali ogrencinin adi {isimler[0]}");
            Console.WriteLine($"{numaralar[1]} numarali ogrencinin adi {isimler[1]}");
            Console.WriteLine($"{numaralar[2]} numarali ogrencinin adi {isimler[2]}");
            Console.WriteLine($"{numaralar[3]} numarali ogrencinin adi {isimler[3]}");
            Console.WriteLine($"{numaralar[4]} numarali ogrencinin adi {isimler[4]}");

            // Dizi Metotları (Array Methods)

            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };
            int[] plakalar = { 34, 6, 35 };
            // sehirler[0] = "Bursa";
            // sehirler.SetValue("Bursa", 0);
            // SetValue: Belirtilen indeksteki elemana yeni bir değer atar.

            Console.WriteLine(sehirler.GetValue(1));    // GetValue: Belirtilen indeksteki elemanın değerini getirir.
            Console.WriteLine(sehirler.Length);
            Console.WriteLine(Array.IndexOf(sehirler, "İzmir"));

            Array.Sort(sehirler);                       // Array.Sort: Dizi elemanlarını küçükten büyüğe veya alfabetik olarak sıralar.
            Array.Sort(plakalar);

            Array.Reverse(plakalar);                    // Array.Reverse: Dizi elemanlarının sırasını ters çevirir.
            Array.Clear(sehirler);                      // Array.Clear: Dizideki elemanları sıfırlar veya varsayılan değerlerine getirir.
            Array.Clear(plakalar, 0, 1);

            Console.WriteLine(plakalar.GetValue(0));
            Console.WriteLine(plakalar.GetValue(1));
            Console.WriteLine(plakalar.GetValue(2));

            // Array Slicing (Dizi Bölme)

            string[] sehirler2 = { "zonguldak", "rize", "kocaeli", "istanbul", "ankara" };

            // var sonuc = sehirler2[0..3];
            // Console.WriteLine(sonuc.Length);

            foreach (var sehir in sehirler2[0..3])      // 0. indexten 3. indexe kadar olan elemanları alır
            {
                Console.WriteLine(sehir);
            }

            string il = "Kocaeli";

            Console.WriteLine(il[..5]);


            // Dizi Uygulama

            // 1. Öğrenciler ve notlar isminde iki dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

            var ogrenciler = new string[3];
            var notlar = new int[3];

            Console.Write("1. Öğrenci Adı: ");
            ogrenciler[0] = Console.ReadLine() ?? "";
            Console.Write("1. Öğrenci Notu: ");
            notlar[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Öğrenci Adı: ");
            ogrenciler[1] = Console.ReadLine() ?? "";
            Console.Write("2. Öğrenci Notu: ");
            notlar[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Öğrenci Adı: ");
            ogrenciler[2] = Console.ReadLine() ?? "";
            Console.Write("3. Öğrenci Notu: ");
            notlar[2] = Convert.ToInt32(Console.ReadLine());


            // 2. Öğrenciler dizisi kaç elemanlıdır, yazdırınız.

            Console.WriteLine("Öğrenciler dizisinin eleman sayisi: " + ogrenciler.Length);


            // 3. İlk 2 öğrencinin isimlerini ve notlarını yazdırınız.

            foreach (var ogrenci in ogrenciler[..2])
            {
                Console.WriteLine(ogrenci);
            }

            foreach (var not in notlar[..2])
            {
                Console.WriteLine(not);
            }


            // 4. Tüm öğrencilerin not ortalaması nedir?

            var not1 = notlar[0];
            var not2 = notlar[1];
            var not3 = notlar[2];
            var ortalama = (not1 + not2 + not3) / 3;

            Console.WriteLine("Tüm öğrencilerin not ortalamasi: " + ortalama);


            /*
            Çok Boyutlu Diziler (Multidimensional Arrays)

            Ali => 50, 60, 70
            Ahmet => 60, 80, 90
            Canan => 50, 70, 30

            => Her öğrencinin not ortalamasını hesaplayınız.
            */

            string[] ogrenciler2 = new string[] { "Ali", "Ahmet", "Canan" };
            int[,] notlar2 = new int[3, 3];

            //Ali
            notlar2[0, 0] = 50;
            notlar2[0, 1] = 60;
            notlar2[0, 2] = 70;

            //Ahmet
            notlar2[1, 0] = 60;
            notlar2[1, 1] = 80;
            notlar2[1, 2] = 90;

            //Canan
            notlar2[2, 0] = 50;
            notlar2[2, 1] = 70;
            notlar2[2, 2] = 30;

            var ortalama_1 = (notlar2[0, 0] + notlar2[0, 1] + notlar2[0, 2]) / 3;
            var ortalama_2 = (notlar2[1, 0] + notlar2[1, 1] + notlar2[1, 2]) / 3;
            var ortalama_3 = (notlar2[2, 0] + notlar2[2, 1] + notlar2[2, 2]) / 3;

            Console.WriteLine($"{ogrenciler2[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
            Console.WriteLine($"{ogrenciler2[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
            Console.WriteLine($"{ogrenciler2[2]} isimli öğrencinin not ortalaması: {ortalama_3}");
        }
    }
}

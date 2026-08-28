namespace consoleAap
{
    public class StringsAndDateTimeNote
    {
        public static void Notlar()
        {
            // --- STRING ISLEMLERI ---
            Console.Write("ad: ");
            var ad = Console.ReadLine();

            Console.Write("soyad: ");
            var soyad = Console.ReadLine();

            Console.Write("yas: ");
            var yas = Console.ReadLine();

            // String interpolation (birleştirme)
            string mesaj2 = $"{ad} {soyad} isimli kisi";
            Console.WriteLine(mesaj2);

            string mesaj = "Ahmet turan isimli kisi";

            var sonuc1 = mesaj.Length;
            var sonuc2 = mesaj.ToLower();
            var sonuc3 = mesaj.ToUpper();
            var sonuc4 = mesaj.Trim();
            var sonuc5 = mesaj.Split(' ')[0];


            // --- DATETIME ISLEMLERI ---
            var simdi = DateTime.Now;

            Console.WriteLine($"Su anki tarih ve saat: {simdi}");
            System.Console.WriteLine(simdi.Year);   // yil
            System.Console.WriteLine(simdi.Month);  // ay
            System.Console.WriteLine(simdi.Day);    // gun
            System.Console.WriteLine(simdi.Hour);   // saat
            System.Console.WriteLine(simdi.Minute); // dakika
            System.Console.WriteLine(simdi.Second); // saniye

            DateTime dt = new DateTime(2023, 6, 15); // 15 Haziran 2023
            DateTime dt2 = dt.AddYears(2);           // 15 Haziran 2025
            DateTime dt3 = dt.AddHours(3);           // 15 Haziran 2023, 3 saat sonra

            System.Console.WriteLine(dt.Year);
            System.Console.WriteLine(dt2.Year);
            System.Console.WriteLine(dt3.Hour);

            var fark = simdi - dt; // simdi ile dt arasındaki farkı verir
            System.Console.WriteLine(fark.TotalDays); // toplam gün sayısı
        }
    }
}
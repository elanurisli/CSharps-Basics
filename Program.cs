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
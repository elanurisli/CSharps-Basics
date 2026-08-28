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
        }
    }
}
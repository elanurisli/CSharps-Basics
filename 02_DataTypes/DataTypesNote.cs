namespace CSharpNotlarim
{
    public class DataTypesNote
    {
        public void Notlar()
        {
/*
    C# VERİ TİPLERİ

    Value Types (Değer Tipleri);

    -> Value types'lar stack'te tutulur ve referans tiplerine göre daha hızlıdır.

    Tam sayılar: (int, long, short, byte)
    Ondalıklı sayılar: (float, double, decimal)
    Diğer veri tipleri: (boolean, char, struct)

    Reference Types (Referans Tipleri);
    string, class, interface, array
*/

{
    int sayi = 200;
    decimal kdvOrani = 1.18m;          //m = decimal yazılırken belirtilmelidir.
    char karakter = 'A';
    bool satistaMi = true;
    string urunAdi = "Samsung S23";
    float fiyat = 1000.25f;            //f = float yazılırken belirtilmelidir.
    double fiyat2 = 1000.25d;

    Console.WriteLine(sayi);
    Console.WriteLine(kdvOrani);
    Console.WriteLine(karakter);
    Console.WriteLine(satistaMi);
    Console.WriteLine(urunAdi);
    Console.WriteLine(fiyat);
    Console.WriteLine(fiyat2);
}

/*
    VERİ TİPİ DÖNÜŞÜMÜNE NEDEN İHTİYAÇ DUYARIZ?
*/

{
    Console.Write("1.sayi: ");          //WriteLine() metodu ile ekrana yazdırma işlemi yapılır ve imleç bir alt satıra geçer.
    var sayi1 = Console.ReadLine();     //ReadLine() metodu string veri tipinde değer döndürür.

    Console.Write("2.sayi: ");          //Write() metodu ile ekrana yazdırma işlemi yapılır ve imleç aynı satırda kalır.
    var sayi2 = Console.ReadLine();
    var toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);
}

/*
1.sayi: 10, 2.sayi: 20 bu şekilde ekrana yazdırıldığında toplam = 1020 olarak ekrana yazdırılır.
Çünkü sayi1 ve sayi2 string (readline) veri tipinde olduğu için toplama işlemi yerine birleştirme işlemi yapılır.
*/

/*
    VERİ TİPİ DÖNÜŞÜMÜ
    --> implicit casting (bilinçsiz dönüşüm) : küçük veri tipinden büyük veri tipine dönüşüm bilinçsiz bir şekilde yapılır.Bu dönüşümde veri kaybı yaşanmaz.
    --> explicit conversion (bilinçli dönüşüm) : büyük veri tipinden küçük veri tipine dönüşüm bilinçli bir şekilde yapılır.Bu dönüşümde veri kaybı yaşanabilir.
*/

{
    int a = 10;
    double b = a; // implicit casting (bilinçsiz dönüşüm) //Bu dönüşümde küçük kaptan büyük kaba dökme yaşanır ve veri kaybı yaşanmaz. Bu nedenle bilinçsiz bir şekilde dönüşüm yapılır.

    double c = 11.2;
    int d = (int)c; // explicit conversion (bilinçli dönüşüm) //Bu dönüşümde büyük kaptan küçük kaba dökme yaşanır ve veri kaybı yaşanabilir. Bu nedenle bilinçli bir şekilde dönüşüm yapılır.

    Console.WriteLine(b);
    Console.WriteLine(d);
}

{
    Console.Write("1.sayi: ");
    var sayi1 = Convert.ToInt32(Console.ReadLine());
    //Convert.ToInt32() metodu ile string veri tipi int veri tipine dönüştürülür.

    Console.Write("2.sayi: ");
    var sayi2 = Convert.ToInt32(Console.ReadLine());

    var toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);
    //1.sayi: 10, 2.sayi: 20 bu şekilde ekrana yazdırıldığında toplam = 30 olarak ekrana yazdırılır.
}

/*
    NULLABLE TYPES (NULL DEĞER ALABİLEN VERİ TİPLERİ)
    --> Mutlaka değer alması gereken veri tipleri null değer alamaz. Örneğin int veri tipi null değer alamaz.
    Ancak int? veri tipi null değer alabilir. Bu nedenle nullable types kullanılır.
    --> Hasvalue ve GetValue metotları nullable types ile birlikte kullanılır.
    Eğer değişken null değer almışsa HasValue metodu false döner. Eğer değişken null değer almamışsa HasValue metodu true döner.
*/

{
    int? sayi = null; //int? veri tipi null değer alabilir.
    Console.WriteLine(sayi);
    Console.WriteLine(sayi.HasValue);
}
        }
    }
}
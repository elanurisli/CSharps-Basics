namespace consoleAap
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysNote.Notlar();

            // Dizi Metotları (Array Methods)
            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };

            Console.WriteLine(sehirler.GetValue(1));
            Console.WriteLine(sehirler.Length);
            Console.WriteLine(Array.IndexOf(sehirler, "İzmir"));

            Array.Sort(sehirler);
        }
    }
}
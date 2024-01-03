namespace Alkatreszek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvas f = new Beolvas();
            Kereses b = new Kereses();
            f.Readin();
            b.Beolvas("adatok.txt");
            b.TipKeres();
            b.Arkereses();
            b.Statisztika();
            b.Akcio();
            b.html();
        }
    }
}
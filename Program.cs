using MyBanker.Classes;

namespace MyBanker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new DebetCard("Hans", new DateOnly(1995, 10, 10));
            Console.WriteLine(c.ToString());
            

            Card m = new MasterCard("Peter", new DateOnly(1995, 10, 10));
            Console.WriteLine(m.ToString());


            Card ma = new MaestroCard("Hans-Peter", new DateOnly(1995, 10, 10));
            Console.WriteLine(ma.ToString());

            Card V = new Visa("Peter-Hans", new DateOnly(1980,10,5));
            Console.WriteLine(V.ToString());
            

            Card VE = new VisaElectron("Krusemynte", new DateOnly(1999,6,6));
            Console.WriteLine(VE.ToString());

        }
    }
}
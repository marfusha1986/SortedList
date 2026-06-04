using System.Collections;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.SortedList auzef = new System.Collections.SortedList();
            auzef.Add("BLPR", "Bilgisayar Programciligi");
            auzef.Add("IKAO", "Iktisat");
            auzef.Add("ISAO", "Isletme");
            auzef.Add("ILHA", "Ilahiyat");
            //Elemanlar listeleniyor
            foreach(string eleman in auzef.Keys)
                Console.WriteLine(eleman + ": "+ auzef[eleman]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrediIObjketiPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sport nogomet = new Sport("nogomet", true, 26);

            Sport vaterpolo = new Sport("vaterpolo", true, 13);

            Sport curling = new Sport("curling", false, 8);



            Console.WriteLine(nogomet.ToString() + Environment.NewLine);

            Console.WriteLine(vaterpolo.ToString() + Environment.NewLine);

            Console.WriteLine(curling.ToString() + Environment.NewLine);

            Console.ReadKey();
        }
    }
}

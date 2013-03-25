using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd_Practicum3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de straal van de cirkel: ");
            double dblStraal = double.Parse(Console.ReadLine());
            Console.Write("Geef de hoogte in: ");
            double dblHoogte = double.Parse(Console.ReadLine());

            double dblOmtrek = 2 * Math.PI * dblStraal;
            double dblVolume = Math.PI * Math.Pow(dblStraal, 2) * dblHoogte;
            double dblOppervlakte = Math.PI * Math.Pow(dblStraal, 2);

            double dblOmtrekAfgerond = Math.Round(dblOmtrek, 2);
            double dblOppAfgerond = Math.Round(dblOppervlakte, 2);
            double dblVolumeAfgerond = Math.Round(dblVolume, 2);

            Console.WriteLine("De omtrek van de cirkel is: " + dblOmtrekAfgerond);
            Console.WriteLine("De oppervlakte van de cirkel is: " + dblOppAfgerond);
            Console.WriteLine("Het volume van de cilinder is: " + dblVolumeAfgerond);
            Console.ReadLine();
        }
    }
}

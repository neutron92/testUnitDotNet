using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlotTravail
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Read();
            var etapes = new List<IEtape>
            {
                new TelechargerVideo()
            };

            var flotTravail = new FlotTravail(etapes);
            var moteur = new MoteurFlotTravail();

            // Act
            moteur.Executer(flotTravail);
            Console.Read();

        }
    }
}

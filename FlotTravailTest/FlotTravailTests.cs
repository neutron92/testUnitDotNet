using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlotTravail;

namespace FlotTravailTest
{
    [TestClass]
    public class FlotTravailTests
    {
        [TestClass]
        public class Executer
        {
            [TestMethod]
            public void FlotTravailContientEtapes_ExecuteChaqueEtape()
            {
                // Arrange
                var etapeBidon = new EtapeBidon();
                var etapes = Enumerable.Repeat(etapeBidon, 3).Cast<IEtape>().ToList();
                var flotTravail = new FlotTravail.FlotTravail(etapes);
                var moteur = new MoteurFlotTravail();

                // Act
                moteur.Executer(flotTravail);

                // Assert
                Assert.AreEqual(3, etapeBidon.NombreAppels);
            }

            private class EtapeBidon : IEtape
            {
                public int NombreAppels { get; private set; } = 0;

                public void Executer()
                {
                    NombreAppels++;
                }
            }
        }
    }
}

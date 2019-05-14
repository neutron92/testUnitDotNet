
using System.Collections.Generic;

namespace FlotTravail
{
    public class FlotTravail
    {
        private List<IEtape> etapes;

        public FlotTravail(List<IEtape> etapes)
        {
            this.etapes = etapes;
        }
        // public System.Collections.Generic.List<global::FlotTravailTest.IEtape> Etapes => etapes;
        //public System.Collections.Generic.List<global::FlotTravailTest.IEtape> Etapes { get {
        //        return etapes;
        //    } }

        public List<IEtape> Etapes { get => etapes; }
    }
}
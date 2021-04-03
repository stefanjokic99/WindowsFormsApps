using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbanje_23_03
{
    class Artikl
    {
        public string nazivArtikla { get; set; }
        public float Cijena { get; set; }

        public Artikl(string naziv, float cijena)
        {
            this.nazivArtikla = naziv;
            this.Cijena = cijena;
        }

        public override string ToString()
        {
            return String.Format("{0, -13}\t{1, 12}", this.nazivArtikla, this.Cijena.ToString("0.#0") + "KM");
        }
    }
}

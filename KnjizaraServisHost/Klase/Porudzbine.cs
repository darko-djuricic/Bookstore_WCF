using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KnjizaraServisHost.Klase
{
    [DataContract]
    public class Porudzbine
    {
        [DataMember]
        public int Id_porudzbine { get; set; }
        [DataMember]
        public int Id_knjige { get; set; }
        [DataMember]
        public int Id_korisnika { get; set; }
        [DataMember]
        public int Kolicina { get; set; }

        public Porudzbine(int id_porudzbine, int id_knjige, int id_korisnika, int kolicina)
        {
            Id_porudzbine = id_porudzbine;
            Id_knjige = id_knjige;
            Id_korisnika = id_korisnika;
            Kolicina = kolicina;
        }

        public override string ToString()
        {
            return Id_porudzbine+"";
        }
    }
}

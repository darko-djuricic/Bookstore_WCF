using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KnjizaraServisHost.Klase
{
    [DataContract]
    public class Knjiga
    {
        [DataMember]
        public int Id_knjige { get; set; }
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public double Cena { get; set; }
        [DataMember]
        public float Popust { get; set; }

        public Knjiga(int id_knjige, string naziv, string autor, double cena, float popust=0)
        {
            Id_knjige = id_knjige;
            Naziv = naziv;
            Autor = autor;
            Cena = cena;
            Popust = popust;
        }

        public override string ToString()
        {
            float ukupnaCena = (float)(Cena - (Cena * Popust));
            return $"\"{Naziv}\" by {Autor} (Cena: {ukupnaCena.ToString("0.00")} RSD)";
        }
    }
}

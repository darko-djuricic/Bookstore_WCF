using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KnjizaraServisHost
{
    public enum Status
    {
        admin,
        korisnik,
        operater
    }
    [DataContract]
    public class Korisnik
    {
        [DataMember]
        public int Id_korisnika { get; set; }
        [DataMember]
        public string Korisnicko_ime { get; set; }
        [DataMember]
        public string Lozinka { get; set; }
        [DataMember]
        internal Status Status { get; set; }


        public Korisnik(int id_korisnika, string korisnicko_ime, string lozinka, Status status)
        {
            Id_korisnika = id_korisnika;
            Korisnicko_ime = korisnicko_ime;
            Lozinka = lozinka;
            Status = status;
        }

        public override string ToString()
        {
            return $"Korisnicko ime: {Korisnicko_ime} (Status: {Status})";
        }

    }
}

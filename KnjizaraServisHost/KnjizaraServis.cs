using KnjizaraServisHost.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnjizaraServisHost
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single, ConcurrencyMode =ConcurrencyMode.Multiple)]
    class KnjizaraServis : IOperater, IKorisnik, IAdmin
    {
        static List<Korisnik> korisnici = new List<Korisnik>()
        {
            new Korisnik(0,"darkonrt14818","dkei2502", Status.admin),
            new Korisnik(1,"viser123","viser321", Status.operater),
            new Korisnik(2,"marko123","marko321", Status.korisnik),
            new Korisnik(3,"marija123","marija321", Status.korisnik),
            new Korisnik(4,"lazar123","lazar321", Status.korisnik),

        };

        static List<Porudzbine> porudzbine = new List<Porudzbine>()
        {
            new Porudzbine(0,1,3,1)
        };

        static List<Knjiga> knjige = new List<Knjiga>()
        {
            new Knjiga(0, "Na Drini cuprija","Ivo Andric",1399.99),
            new Knjiga(1, "Tvrdjava","Mesa Selimovic",999.99),
            new Knjiga(2, "Lovac na zmajeve","Haled Hoseini",1200.00,0.2f),
            new Knjiga(3, "Da Vincijev kod","Den Braun",1600.30),
            new Knjiga(4, "Ubiti pticu rugalicu","Harper Li",1399.99,0.1f),
            new Knjiga(5, "Rat i mir","Lav Tolstoj",2199.99),
            new Knjiga(6, "Zlocin i kazna","Fjord Mihajlovic Dostojevski",1900.00),
            new Knjiga(7, "Gorski Vijenac","Petar II Petrovic - Njegos",1299.99),
            new Knjiga(8, "Ana Karenjina","Lav Tolstoj", 2350.45),
            new Knjiga(9, "Proces","Franc Kafka", 899.99),
        };

        static Korisnik ulogovan=null;

        public bool IzmeniKnjigu(int id_knjige, Knjiga k)
        {
            var index = knjige.FindIndex(e => e.Id_knjige == id_knjige);
            var uslov = index > -1;
            if (uslov)
            {
                k.Id_knjige = id_knjige;
                knjige[index] = k;
            }

            return uslov;
        }

        public bool IzmeniKorisnika(int id_korisnika, Korisnik k)
        {
            var index = korisnici.FindIndex(e => e.Id_korisnika == id_korisnika);
            var uslov = index > -1;
            if (uslov)
            {
                k.Id_korisnika = id_korisnika;
                korisnici[index] = k;
            }

            return uslov;
        }

        public bool ObrisiKnjigu(int id_knjige)
        {
            var knjiga = knjige.FirstOrDefault(k => k.Id_knjige == id_knjige);
            var uslov = knjiga != null;

            if (uslov)
                knjige.Remove(knjiga);

            return uslov;
        }

        public bool ObrisiKorisnika(int id_korisnika)
        {
            var kor = korisnici.FirstOrDefault(k => k.Id_korisnika == id_korisnika);
            var uslov = kor != null;

            if (uslov)
                korisnici.Remove(kor);

            return uslov;
        }

        public bool OtkaziPorudzbinu(string id_por)
        {
            var porudzbina = porudzbine.SingleOrDefault(p => p.Id_porudzbine == int.Parse(id_por.Trim()));
            var uslov = porudzbina != null;
            if (uslov)
                porudzbine.Remove(porudzbina);
            return uslov;
        }

        public void PoruciKnjigu(Porudzbine p)
        {
            p.Id_porudzbine = porudzbine.Count < 1?0:porudzbine.Max(e => e.Id_porudzbine) + 1;
            porudzbine.Add(p);
        }

        public IEnumerable<Porudzbine> PorudzbineKorisnika(string id_korisnika)
        { 
            return porudzbine.Where(p => p.Id_korisnika == int.Parse(id_korisnika.Trim()));
        }

        public bool PostaviPopust(int id_knjige, float popust)
        {
            var knjiga = knjige.FirstOrDefault(k => k.Id_knjige == id_knjige);
            var uslov = knjiga != null;
            if (uslov)
                knjiga.Popust = popust;
            return uslov;
        }

        public IEnumerable<Porudzbine> PregledPorudzbina() => porudzbine;

        public Korisnik Prijava(string username, string password)
        {
            var korisnik = korisnici.FirstOrDefault(k => k.Korisnicko_ime == username && k.Lozinka == password);
            Thread.Sleep(2000);
            if (korisnik != null)
                Console.WriteLine("\nUlogovao se korisnik: "+korisnik.ToString()+$" -> {DateTime.Now.ToLongTimeString()}");
            return korisnik;
        }

        public IEnumerable<Knjiga> SveKnjige() => knjige;

        public IEnumerable<Korisnik> SviKorisnici() => korisnici;

        public void UnesiKnjigu(Knjiga k) => knjige.Add(k);

        public void UnesiKorisnika(Korisnik k) => korisnici.Add(k);
    }
}

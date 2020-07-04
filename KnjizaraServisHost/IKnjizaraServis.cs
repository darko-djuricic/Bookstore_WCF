using KnjizaraServisHost.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace KnjizaraServisHost
{
    [ServiceContract]
    public interface IOperater:IKorisnik
    {
        [OperationContract]
        void UnesiKnjigu(Knjiga k);
        [OperationContract]
        void UnesiKorisnika(Korisnik k);

        [OperationContract]
        bool IzmeniKnjigu(int id_knjige, Knjiga k);
        [OperationContract]
        bool IzmeniKorisnika(int id_korisnika, Korisnik k);
        [OperationContract]
        IEnumerable<Porudzbine> PregledPorudzbina();
        [OperationContract]
        IEnumerable<Korisnik> SviKorisnici();

        [OperationContract]
        bool PostaviPopust(int id_knjige, float popust);
    }
    [ServiceContract]
    public interface IKorisnik:IPrijava
    {
        [WebGet(UriTemplate="knjige", ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        IEnumerable<Knjiga> SveKnjige();

        [WebGet(UriTemplate = "porudzbina/{id_korisnika}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        IEnumerable<Porudzbine> PorudzbineKorisnika(string id_korisnika);

        [WebInvoke(UriTemplate="knjige/poruci", Method ="POST", RequestFormat =WebMessageFormat.Json)]
        [OperationContract]
        void PoruciKnjigu(Porudzbine p);

        [WebInvoke(UriTemplate = "porudzbina/otkazi/{id_por}", Method = "DELETE")]
        [OperationContract]
        bool OtkaziPorudzbinu(string id_por);
    }
    

    [ServiceContract]
    public interface IAdmin : IOperater
    {
        [OperationContract]
        bool ObrisiKnjigu(int id_knjige);

        [OperationContract]
        bool ObrisiKorisnika(int id_korisnika);
    }
    [ServiceContract]
    public interface IPrijava
    {
        [WebInvoke(Method = "POST", UriTemplate = "prijava"
            , RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle =WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        Korisnik Prijava(string username, string password);
    }
}

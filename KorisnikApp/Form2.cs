using KorisnikApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnikApp
{
    public partial class Form2 : Form
    {
        static Korisnik ulogovan;
        static BindingList<Knjiga> knjige;
        static BindingList<Porudzbina> porudzbine;
        KorisnikClient proxy;
        public Form2(Korisnik k)
        {
            ulogovan = k;
            knjige = new BindingList<Knjiga>();
            porudzbine = new BindingList<Porudzbina>();
            proxy = new KorisnikClient();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblOperator.Text = $"Dobrodosli {ulogovan.Korisnicko_ime}";
            lbKnjige.DataSource = knjige;
            lbPorudzbine.DataSource = porudzbine;
            dohvatiKnjige();
        }
        private async void dohvatiKnjige() => await proxy.SveKnjigeAsync()
                            .ContinueWith(k =>
                            {
                                k.Result.ToList().ForEach(e => knjige.Add(e));
                            })
                            .ContinueWith(p=> dohvatiPorudzbine());

        private async void dohvatiPorudzbine() => await proxy.PorudzbineKorisnikaAsync(ulogovan.Id_korisnika.ToString())
                            .ContinueWith(p =>
                            {
                                p.Result.ToList().ForEach(por => 
                                {
                                    var knjiga = knjige.Where(e => e.Id_knjige == por.Id_knjige).ToArray()[0];
                                    porudzbine.Add(new Porudzbina()
                                    {
                                        id_porudzbine=por.Id_porudzbine,
                                        knjiga = $"\"{knjiga.Naziv}\" od {knjiga.Autor}",
                                        kolicina = por.Kolicina
                                    });
                                });
                            });


        private async void btnPoruci_Click_1(object sender, EventArgs e)
        {
            var knjiga = lbKnjige.SelectedItem as Knjiga;
            var rez = MessageBox.Show("Da li ste sigurni da zelite da porucite knjigu:\n" + knjiga.ToString(), "Porudzbina", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Porudzbine p = new Porudzbine()
                {
                    Id_korisnika = ulogovan.Id_korisnika,
                    Id_knjige = knjiga.Id_knjige,
                    Kolicina = (int)numKolicina.Value
                };
                await proxy.PoruciKnjiguAsync(p)
                    .ContinueWith(previous => porudzbine.Add(new Porudzbina()
                            {
                                id_porudzbine=porudzbine.Count==0?0:porudzbine.Max(po=>po.id_porudzbine)+1,
                                knjiga=$"\"{knjiga.Naziv}\" od {knjiga.Autor}",
                                kolicina=p.Kolicina
                            })
                    );
                MessageBox.Show("Uspesno ste porucili knjigu");
            }
        }

        private async void btnOtkazi_Click(object sender, EventArgs e)
        {
            var por = lbPorudzbine.SelectedItem as Porudzbina;
            var rez = MessageBox.Show("Da li ste sigurni da zelite da otkazete porudzbinu:\n" + por.ToString(), "Porudzbina", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
                await proxy.OtkaziPorudzbinuAsync(por.id_porudzbine.ToString())
                    .ContinueWith(p =>
                    {
                        MessageBox.Show(p.Result?"Uspesno ste otkazali porudzbinu":"Doslo je do greske");
                        if (p.Result)
                            porudzbine.Remove(por);
                    });
        }
    }

    class Porudzbina
    {
        public int id_porudzbine;
        public string knjiga;
        public int kolicina;

        public override string ToString()
        {
            return $"Porudzbina: {id_porudzbine}; Knjiga: {knjiga} (Kolicina: {kolicina})";
        }
    }
}

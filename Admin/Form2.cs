using Admin.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Form2 : Form
    {
        Korisnik ulogovan;
        AdminClient proxy;
        static BindingList<Knjiga> knjige;
        static BindingList<Korisnik> korisnici;
        static BindingList<Porudzbina> porudzbine;
        public Form2(Korisnik k)
        {
            ulogovan = k;
            proxy = new AdminClient();
            knjige = new BindingList<Knjiga>();
            korisnici = new BindingList<Korisnik>();
            porudzbine = new BindingList<Porudzbina>();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblOperator.Text = $"Dobrodosli {ulogovan.Korisnicko_ime}";
            lbKorisnici.DataSource = korisnici;
            lbKnjige.DataSource = knjige;
            lbPorudzbine.DataSource = porudzbine;
            dohvatiKnjige();
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
        }
        private async void dohvatiPorudzbine()
        {
            await proxy.PregledPorudzbinaAsync()
                                      .ContinueWith(p => p.Result.OfType<Porudzbine>().ToList())
                                      .ContinueWith(p =>
                                      {
                                          foreach (var por in p.Result)
                                          {
                                              var username = korisnici.Where(e => e.Id_korisnika == por.Id_korisnika).ToArray()[0].Korisnicko_ime;
                                              var knjiga = knjige.Where(e => e.Id_knjige == por.Id_knjige).ToArray()[0];
                                              porudzbine.Add(new Porudzbina()
                                              {
                                                  id_porudzbine = por.Id_porudzbine,
                                                  knjiga = $"\"{knjiga.Naziv}\" od {knjiga.Autor}",
                                                  kolicina=por.Kolicina,
                                                  korisnik=username
                                              });
                                          }
                                      });
        }

        private async void dohvatiKnjige() => await proxy.SveKnjigeAsync()
                                    .ContinueWith(k =>
                                    {
                                        k.Result.ToList().ForEach(e => knjige.Add(e));
                                    }).ContinueWith(p=> dohvatiKorisnike());

        private async void dohvatiKorisnike() => await proxy.SviKorisniciAsync()
                                    .ContinueWith(k => 
                                    {
                                        k.Result.ToList().ForEach(e => korisnici.Add(e));
                                    }).ContinueWith(p=> dohvatiPorudzbine());

        private void lbKnjige_Click(object sender, EventArgs e)
        {
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
            Knjiga knjiga = lbKnjige.SelectedItem as Knjiga;
            tboxNaziv.Text = knjiga.Naziv;
            tboxAutor.Text = knjiga.Autor;
            numCena.Value = (decimal)knjiga.Cena;
            numPopust.Value = (decimal)(knjiga.Popust * 100);
            tboxUkupnaCena.Text = (knjiga.Cena - (knjiga.Cena * knjiga.Popust)).ToString("0.00") + " RSD";
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            var knjiga = lbKnjige.SelectedItem as Knjiga;
            var izmenjena = new Knjiga()
            {
                Id_knjige = knjiga.Id_knjige,
                Naziv = tboxNaziv.Text.Trim(),
                Autor = tboxAutor.Text.Trim(),
                Cena = (double)numCena.Value,
                Popust = (float)(numPopust.Value / 100)
            };

            if (izmenjena.Equals(knjiga))
                MessageBox.Show("Nije doslo do nikakve izmene", "Izmena knjige");
            else
            {
                await proxy.IzmeniKnjiguAsync(knjiga.Id_knjige, izmenjena)
                    .ContinueWith(p=>
                    {
                        MessageBox.Show(p.Result ? "Uspesno ste izmenili knjigu": "Doslo je do greske, molimo Vas pokusajte kasnije.", "Izmena knjige");
                        if (p.Result)
                        {
                            knjige.Remove(knjiga);
                            knjige.Add(izmenjena);
                        }

                    });
                
                
                tboxNaziv.Text = "";
                tboxAutor.Text = "";
                numCena.Value = 1;
                numPopust.Value = 0;
                tboxUkupnaCena.Text = "";
            }
            
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var knjiga = new Knjiga()
            {
                Id_knjige = knjige.Max(i => i.Id_knjige) + 1,
                Naziv = tboxNaziv.Text.Trim(),
                Autor = tboxAutor.Text.Trim(),
                Cena = (double)numCena.Value,
                Popust = (float)(numPopust.Value / 100)
            };
            var provera = knjige.FirstOrDefault(k => k.Naziv.Equals(knjiga.Naziv) && k.Autor.Equals(knjiga.Autor)) == null;
            if (provera)
            {
                await proxy.UnesiKnjiguAsync(knjiga).ContinueWith(p => knjige.Add(knjiga));
            }

            MessageBox.Show(provera ? "Uspesno ste dodali knjigu" : "Knjiga vec postoji u sistemu", "Dodaj knjigu");
        }

        private void lbKorisnici_Click(object sender, EventArgs e)
        {
            btnIzmeniKorisnika.Enabled = true;
            btnObrisiKorisnika.Enabled = true;
            var korisnik = lbKorisnici.SelectedItem as Korisnik;
            tbUsername.Text = korisnik.Korisnicko_ime;
            tbPassword.Text = korisnik.Lozinka;
            cmbStatus.SelectedItem = korisnik.Status;
        }

        private async void btnIzmeniKorisnika_Click(object sender, EventArgs e)
        {
            btnIzmeni.Enabled = false;
            var korisnik = lbKorisnici.SelectedItem as Korisnik;
            var izmenjen = new Korisnik()
            {
                Id_korisnika = korisnik.Id_korisnika,
                Korisnicko_ime = tbUsername.Text.Trim(),
                Lozinka = tbPassword.Text,
                Status = (Status)cmbStatus.SelectedItem
            };

            if (izmenjen.Equals(korisnik))
                MessageBox.Show("Nije doslo do nikakve izmene", "Izmena knjige");
            else
            {
                await proxy.IzmeniKorisnikaAsync(korisnik.Id_korisnika, izmenjen)
                    .ContinueWith(rez=>
                    {
                        MessageBox.Show(rez.Result ? "Uspesno ste izmenili korisnika" : "Doslo je do greske, molimo Vas pokusajte kasnije.", "Izmena korisnika");
                        if (rez.Result)
                        {
                            korisnici.Remove(korisnik);
                            korisnici.Add(izmenjen);
                        }
                            
                    });
                tbUsername.Text = "";
                tbPassword.Text = "";
                cmbStatus.SelectedIndex = 0;
            }
            
            btnIzmeni.Enabled = true;
        }

        private async void btnSnimiKorisnika_Click(object sender, EventArgs e)
        {
            var korisnik = new Korisnik()
            {
                Id_korisnika = korisnici.Max(i => i.Id_korisnika) + 1,
                Korisnicko_ime = tbUsername.Text.Trim(),
                Lozinka = tbPassword.Text,
                Status = (Status)cmbStatus.SelectedItem
            };
            var provera = korisnici.FirstOrDefault(k => k.Korisnicko_ime.Equals(korisnik.Korisnicko_ime)) == null;
            if (provera)
            {
                await proxy.UnesiKorisnikaAsync(korisnik).ContinueWith(p => korisnici.Add(korisnik));
            }

            MessageBox.Show(provera ? "Uspesno ste dodali korisnika" : "Username zauzet", "Dodaj knjigu");
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var knjiga = lbKnjige.SelectedItem as Knjiga;
            await proxy.ObrisiKnjiguAsync(knjiga.Id_knjige)
                .ContinueWith(rez=>
                {
                    MessageBox.Show(rez.Result ? "Uspesno ste obrisali knjigu" : "Doslo je do greske", "Brisanje knjige");
                    if (rez.Result)
                        knjige.Remove(knjiga);

                    
                });
            
        }

        private async void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            var korisnik = lbKorisnici.SelectedItem as Korisnik;
            await proxy.ObrisiKorisnikaAsync(korisnik.Id_korisnika)
                .ContinueWith(rez =>
                {
                    MessageBox.Show(rez.Result ? "Uspesno ste obrisali korisnika" : "Doslo je do greske", "Brisanje korisnika");
                    if (rez.Result)
                        korisnici.Remove(korisnik);
       
                });
        }

        private async void btnObrisiPor_Click(object sender, EventArgs e)
        {
            var por = lbPorudzbine.SelectedItem as Porudzbina;
            await proxy.OtkaziPorudzbinuAsync(por.id_porudzbine.ToString())
                .ContinueWith(p =>
                {
                    MessageBox.Show (p.Result ? "Uspesno ste otkazili porudzbinu" : "Doslo je do greske", "Otkazivanje porudzbine");
                    if (p.Result)
                        porudzbine.Remove(por);
                });
        }

    }

    class Porudzbina
    {
        public int id_porudzbine;
        public string knjiga;
        public string korisnik;
        public int kolicina;

        public override string ToString()
        {
            return $"Broj porudzbine: {id_porudzbine}; Korisnik: {korisnik}; Knjiga: {knjiga} (Kolicina: {kolicina})";
        }
    }
}

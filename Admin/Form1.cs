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
    public partial class Form1 : Form
    {
        AdminClient proxy;
        public Form1()
        {
            proxy = new AdminClient();
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            lblProvera.Text = "";
            var korisnik = await proxy.PrijavaAsync(txtUsername.Text, txtPassword.Text);
            if (korisnik != null && korisnik.Status == Status.admin)
            {
                Form2 f = new Form2(korisnik);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
                lblProvera.Text = "Pogresan username ili sifra";
            btnLogin.Enabled = true;
        }
    }
}

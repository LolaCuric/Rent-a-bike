using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rent_a_bike
{
    public partial class Ulogovanje : Form
    {
        public Ulogovanje()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Unesite email i lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Povezivanje.Connect();
                    SqlCommand komanda = new SqlCommand("Select * from kupac where email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_email.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Login Successful!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            Program.user_id = (int)tabela.Rows[0]["id_kupca"];
                            this.Close();
                            Welcome frm_welcome = new Welcome();
                            frm_welcome.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka");
                            StringBuilder komanda2 = new StringBuilder("select pass from kupac where email = '");
                            komanda2.Append(txt_email.Text+ " '");
                            SqlCommand naredba2 = new SqlCommand(komanda2.ToString(), veza);
                            SqlDataAdapter adapter2 = new SqlDataAdapter(naredba2);
                            DataTable tabela2 = new DataTable();
                            adapter2.Fill(tabela2);
                            MessageBox.Show(tabela2.Rows[0][0].ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email!");
                    }
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }

            }

        }

        private void linklbl_nalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Novi_nalog frm_novi_nalog = new Novi_nalog();
            frm_novi_nalog.Show();
            this.Hide();
        }

        private void Ulogovanje_Load(object sender, EventArgs e)
        {

        }

        private void linklbl_sifra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Promena_sifre frm_pr = new Promena_sifre();
            frm_pr.Show();
            this.Hide();
        }
    }
}

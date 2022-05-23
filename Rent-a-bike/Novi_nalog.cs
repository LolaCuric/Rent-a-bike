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
    public partial class Novi_nalog : Form
    {
        public Novi_nalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_brlk.Text == "" || txt_email.Text == "" ||
               txt_ime.Text == "" || txt_pass.Text == "" || txt_pass2.Text == "" || txt_prezime.Text == "")
            {
                MessageBox.Show("Niste sve uneli.");
            }
            else
            {
                if (txt_pass.Text == txt_pass2.Text)
                {
                    StringBuilder naredba = new StringBuilder("Insert into kupac(ime,prezime,brlk,email,pass,br_racuna,uloga) values('");
                    naredba.Append(txt_ime.Text + "', '");
                    naredba.Append(txt_prezime.Text + "', '");
                    naredba.Append(txt_brlk.Text + "', '");
                    naredba.Append(txt_email.Text + "', '");
                    naredba.Append(txt_pass.Text + "', '");
                    naredba.Append(txt_brrac.Text + "', 1 )");
                    SqlConnection veza = Povezivanje.Connect();
                    SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
                    try
                    {
                        veza.Open();
                        komanda.ExecuteNonQuery();
                        veza.Close();
                        Ulogovanje frm_ul = new Ulogovanje();
                        frm_ul.Show();
                        this.Hide();

                    }
                    catch (Exception greska)
                    {
                        MessageBox.Show(greska.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli istu sifru");
                }
            }

        }

        private void Novi_nalog_Load(object sender, EventArgs e)
        {
           
        }
    }
}

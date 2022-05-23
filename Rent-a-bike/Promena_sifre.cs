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
    public partial class Promena_sifre : Form
    {
        public Promena_sifre()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "" || txt_pass2.Text =="")
            {
                MessageBox.Show("Niste uneli potrebne podatke");
            }
            else
            {
                if (txt_pass.Text == txt_pass2.Text)
                {
                    try
                    {
                        SqlConnection veza = Povezivanje.Connect();
                        
                        StringBuilder naredba = new StringBuilder("Update kupac set pass= '");
                        naredba.Append(txt_pass.Text + " ' where email = '");
                        naredba.Append(txt_email.Text + " '");

                        SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
                        try
                        {
                            veza.Open();
                            komanda.ExecuteNonQuery();
                            veza.Close();
                            //promeni u sql ali ga ne registruje visual studio

                            this.Hide();
                            Ulogovanje frm_ul = new Ulogovanje();
                            frm_ul.Show();
                        }
                        catch(Exception greska)
                        {
                            MessageBox.Show(greska.Message);
                        }

                        
                    }
                    catch(Exception greska)
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

        private void Promena_sifre_Load(object sender, EventArgs e)
        {

        }
    }
}

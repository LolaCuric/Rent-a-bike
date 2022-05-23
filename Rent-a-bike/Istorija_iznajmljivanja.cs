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
    public partial class Istorija_iznajmljivanja : Form
    {
        public Istorija_iznajmljivanja()
        {
            InitializeComponent();
        }

        private void Istorija_iznajmljivanja_Load(object sender, EventArgs e)
        {
            filuj();    
        }

        private void filuj()
        {
            try
            {
                SqlConnection veza = Povezivanje.Connect();
                StringBuilder komanda = new StringBuilder("select proizvod.naziv, vreme_iznajmljivanja, vreme_vracanja from iznajmljivanje join ");
                komanda.Append(" proizvod on proizvod.id = iznajmljivanje.id_proizvoda join kupac on kupac.id_kupca = iznajmljivanje.id_kupca where ");
                komanda.Append(" kupac.ime = '" + Program.user_ime + "' and kupac.prezime= '" + Program.user_prezime + "'");
                SqlDataAdapter adapter = new SqlDataAdapter(komanda.ToString(), veza);
                DataTable Proizvodii = new DataTable();
                adapter.Fill(Proizvodii);
                dataGridView1.DataSource = Proizvodii;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch(Exception okr)
            {
                MessageBox.Show(okr.Message);
            }
        }
    }
}

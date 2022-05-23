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
    public partial class Oprema : Form
    {
        DataTable Proizvodi;
        public Oprema()
        {
            InitializeComponent();
        }

        private void Oprema_Load(object sender, EventArgs e)
        {
            filuj();
        }

        private void filuj()
        {
            SqlConnection veza = Povezivanje.Connect();
            StringBuilder komanda = new StringBuilder("select proizvod.naziv, serijski_broj," +
                " proizvodjac, uzrast.naziv as uzrast, cena_h as 'Cena po satu' from proizvod ");
            komanda.Append(" join tip on tip.id = proizvod.tip join uzrast on uzrast.id = proizvod.uzrast where tip.naziv = 'Oprema'");
            SqlDataAdapter adapter = new SqlDataAdapter(komanda.ToString(), veza);
            Proizvodi = new DataTable();
            adapter.Fill(Proizvodi);
            dataGridView1.DataSource = Proizvodi;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Oprema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Welcome frm_wel = new Welcome();
            frm_wel.Show();
        }
    }
}

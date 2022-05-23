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
    public partial class Iznajmljivanje : Form
    {
        DataTable Proizvodi;
        public int broj_sloga;
        public Iznajmljivanje()
        {
            InitializeComponent();
        }

        private void Iznajmljivanje_Load(object sender, EventArgs e)
        {
            filuj();
        }

        private void filuj()
        {
            SqlConnection veza = Povezivanje.Connect();
            StringBuilder komanda = new StringBuilder("select proizvod.naziv as proizvod, tip.naziv as tip," +
                " uzrast.naziv as uzrast, cena_h as 'Cena po satu' from proizvod ");
            komanda.Append(" join tip on tip.id = proizvod.tip join uzrast on uzrast.id = proizvod.uzrast");
            SqlDataAdapter adapter = new SqlDataAdapter(komanda.ToString(), veza);
            Proizvodi = new DataTable();
            adapter.Fill(Proizvodi);
            dataGridView1.DataSource = Proizvodi;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            broj_sloga = dataGridView1.CurrentRow.Index;
            textBox1.Text=dataGridView1.Rows[e.RowIndex].Cells["proizvod"].Value.ToString();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zabelezili smo Vasu rezervaciju");
            
            SqlConnection veza = Povezivanje.Connect();
            StringBuilder komanda1 = new StringBuilder("Insert into iznajmljivanje(id_kupca, id_proizvoda," +
                "vreme_iznajmljivanja, vreme vracanja) values(" );
            komanda1.Append(Program.user_id + ", " + broj_sloga + ", '" + dateTimePicker1.Value.ToString());
            komanda1.Append("' , '"+dateTimePicker2.Value.ToString()+"' )");
            SqlCommand naredba1 = new SqlCommand(komanda1.ToString(), veza);
            veza.Open();
            //naredba1.ExecuteNonQuery();
            veza.Close(); 
        }
    }
}

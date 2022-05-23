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
    public partial class Kvar : Form
    {
        public Kvar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmb1_populate()
        {
            SqlConnection veza = Povezivanje.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from tip", veza);
            DataTable tip = new DataTable();
            adapter.Fill(tip);
            comboBox1.DataSource = tip;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
            comboBox1.SelectedValue = 1;
        }

        private void cmb2_populate()
        {
            SqlConnection veza = Povezivanje.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from proizvod " +
                " join tip on tip.id = proizvod.tip where " +
                "proizvod.tip = '" + comboBox1.SelectedValue.ToString() + " '", veza);
            DataTable tipp = new DataTable();
            adapter.Fill(tipp);
            comboBox2.DataSource = tipp;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "naziv";
            comboBox2.SelectedValue = -1;

        }

        private void Kvar_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            cmb1_populate();
            cmb2_populate();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.IsHandleCreated && comboBox1.Focused)
            {
                comboBox2.Enabled = true;
                cmb2_populate();
            }
            
        }

        private void btn_salji_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("Update proizvod set komentar = '" +richTextBox1.Text+ " ' where ");
            naredba.Append(" naziv= '" + comboBox2.Text+ "'");
            SqlConnection veza = Povezivanje.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                richTextBox1.Text = "";
                MessageBox.Show("Javicemo Vam se u roku od 5 radnih dana.");
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

           
        }
    }
}

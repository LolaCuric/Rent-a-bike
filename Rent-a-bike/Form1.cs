using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_bike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nastavi_Click(object sender, EventArgs e)
        {
            Ulogovanje frm_ulogovanje = new Ulogovanje();
            frm_ulogovanje.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_nastavi;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}

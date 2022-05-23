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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }


        private void Welcome_Load(object sender, EventArgs e)
        {
            lbl_user.Text = Program.user_ime + " " + Program.user_prezime;

        }

        private void sVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sve frm_sve = new Sve();
            frm_sve.Show();
            this.Close();
        }

        private void bICIKLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bicikli frm_bic = new Bicikli();
            frm_bic.Show();
            this.Close();
        }

        private void rOLERIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roleri frm_rol = new Roleri();
            frm_rol.Show();
            this.Close();
        }

        private void oPREMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oprema frm_oprema = new Oprema();
            frm_oprema.Show();
            this.Close();
        }

        private void pRIJAVITEKVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kvar frm_kvar = new Kvar();
            frm_kvar.Show();
            this.Close();
        }

        private void iSTORIJAIZNAJMLJIVANJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istorija_iznajmljivanja frm_ist = new Istorija_iznajmljivanja();
            frm_ist.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void iZNAJMLJIVANJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iznajmljivanje izn = new Iznajmljivanje();
            izn.Show();
            this.Close();
        }
    }
}

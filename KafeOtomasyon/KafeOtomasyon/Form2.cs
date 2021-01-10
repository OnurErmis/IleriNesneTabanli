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
namespace KafeOtomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GVCT0J0;Initial Catalog=kullanici;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            formsiparis frm3 = new formsiparis();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            frmgnclle formguncel = new frmgnclle();
            formguncel.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmkayit formkayit = new frmkayit();
            formkayit.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (frmgiris.yetkii==true)
            {
                button3.Enabled = true;
                button4.Enabled = true;

            }
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;

            }
        }
    }
}

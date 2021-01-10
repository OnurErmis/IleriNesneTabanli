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
    public partial class frmgnclle : Form
    {
        public frmgnclle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GVCT0J0;Initial Catalog=kullanici;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kullanicilar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void btngncl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kullanicilar set kullanici_adi='"+textBox1.Text.ToString()+"',sifre='"+textBox2.Text.ToString()+"'where id=" + id+ "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void frmgnclle_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

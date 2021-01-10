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
    public partial class frmkayit : Form
    {
        public frmkayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GVCT0J0;Initial Catalog=kullanici;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string a = "insert into Kullanicilar (kullanici_adi,sifre,yetki) values (@kullanici_ad,@sifresi,@yetkisi)";                
                SqlCommand komut = new SqlCommand(a,baglanti);                
                komut.Parameters.AddWithValue("@kullanici_ad", textBox1.Text);
                komut.Parameters.AddWithValue("@sifresi", textBox2.Text);
                if (radioButton2.Checked == true)
                {
                    komut.Parameters.AddWithValue("@yetkisi", 0);
                }
                else
                {
                    komut.Parameters.AddWithValue("@yetkisi", 1);
                }
                komut.ExecuteNonQuery(); ;
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi", "Bilgi");
                

            }
            catch (Exception hata)
            {

                MessageBox.Show("hata");
            }




        }

        private void frmkayit_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GVCT0J0;Initial Catalog=kullanici;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static bool yetkii = false;
            

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                DataTable dt = new DataTable();
               /* dt.Clear();*/
                string sql = "Select * from kullanicilar where kullanici_adi=@kadi AND sifre=@sifresi ";
                SqlParameter prm1 = new SqlParameter("kadi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(dt.Rows[0]["yetki"])==true)
                    {
                        yetkii = true;
                    }
                    else
                    {
                        yetkii = false;
                    }
                    this.Hide();
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                    frmgiris fr1 = new frmgiris();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                    dt.Dispose();
                    da.Dispose();
                    komut.Dispose();
                    baglanti.Close();
                }                           
                
                
            }
            catch (Exception)
            {
               
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

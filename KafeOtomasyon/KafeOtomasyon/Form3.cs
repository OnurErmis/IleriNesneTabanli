using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyon
{
    public partial class formsiparis : Form
    {
        const double patatesfiyat = 7.5;
        const double salatafiyat = 5;
        const double hamburgerfiyat = 19.99;
        const double soganhalkafiyat = 5;
        const double tonsalatafiyat = 7.5;
        const double tonsandvicfiyat = 8;
        const double islakburgerfiyat = 12.5;
        const double janbonsandvicfiyat = 8;
        const double tavuksandvicfiyat = 8;
        const double tiramisufiyat = 13;
        const double cheesecakefiyat = 14;
        const double lokmafiyat = 7.5;
        const double muffinfiyat = 14.5;
        const double pankekfiyat = 11;
        const double cayfiyat = 1.5;
        const double kahvefiyat = 9;
        const double kolafiyat = 6;
        const double meyvesuyufiyat = 13;
        const double sufiyat = 1.5;
        const double vanilyashakefiyat = 12;
        const double cikolatashakefiyat = 12;
        const double cilekshakefiyat = 12;
        const double ormanmeyveshakefiyat = 12;
        const double vergioranı = 1.8;
        double iVergi, kdvsizToplam, iToplam;


        public formsiparis()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Onaylıyor musunuz ?", "Menü", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Close();
            }
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);

            Action<Control.ControlCollection> func1 = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);

        }
        private void textboxlar()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
            txttoplam.Enabled = true;
            txtvergisiz.Enabled = true;
            txtvergi.Enabled = true;
            txtpru.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbOdeme.Items.Add("Nakit");
            cmbOdeme.Items.Add("Master Card");
            cmbOdeme.Items.Add("VISA");
            cmbOdeme.Items.Add("Ticket");

            textboxlar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpatates.Enabled = true;
                txtpatates.Text = "";
                txtpatates.Focus();
            }
            else
            {
                txtpatates.Enabled = false;
                txtpatates.Text = "0";
            }
        }

        private void chcsalata_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsalata.Checked == true)
            {
                txtsalata.Enabled = true;
                txtsalata.Text = "";
                txtsalata.Focus();
            }
            else
            {
                txtsalata.Enabled = false;
                txtsalata.Text = "0";
            }
        }

        private void chcburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chcburger.Checked == true)
            {
                txtburger.Enabled = true;
                txtburger.Text = "";
                txtburger.Focus();
            }
            else
            {
                txtburger.Enabled = false;
                txtburger.Text = "0";
            }
        }

        private void chcsogan_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsogan.Checked == true)
            {
                txtsogan.Enabled = true;
                txtsogan.Text = "";
                txtsogan.Focus();
            }
            else
            {
                txtsogan.Enabled = false;
                txtsogan.Text = "0";
            }
        }

        private void chcton_CheckedChanged(object sender, EventArgs e)
        {
            if (chcton.Checked == true)
            {
                txtton.Enabled = true;
                txtton.Text = "";
                txtton.Focus();
            }
            else
            {
                txtton.Enabled = false;
                txtton.Text = "0";
            }
        }

        private void chctons_CheckedChanged(object sender, EventArgs e)
        {
            if (chctons.Checked == true)
            {
                txttons.Enabled = true;
                txttons.Text = "";
                txttons.Focus();
            }
            else
            {
                txttons.Enabled = false;
                txttons.Text = "0";
            }
        }

        private void chcislak_CheckedChanged(object sender, EventArgs e)
        {
            if (chcislak.Checked == true)
            {
                txtislak.Enabled = true;
                txtislak.Text = "";
                txtislak.Focus();
            }
            else
            {
                txtislak.Enabled = false;
                txtislak.Text = "0";
            }
        }

        private void chcsand_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsand.Checked == true)
            {
                txtsand.Enabled = true;
                txtsand.Text = "";
                txtsand.Focus();
            }
            else
            {
                txtsand.Enabled = false;
                txtsand.Text = "0";
            }
        }

        private void chctvk_CheckedChanged(object sender, EventArgs e)
        {
            if (chctvk.Checked == true)
            {
                txttvk.Enabled = true;
                txttvk.Text = "";
                txttvk.Focus();
            }
            else
            {
                txttvk.Enabled = false;
                txttvk.Text = "0";
            }
        }

        private void t_CheckedChanged(object sender, EventArgs e)
        {
            if (chctir.Checked == true)
            {
                txttir.Enabled = true;
                txttir.Text = "";
                txttir.Focus();
            }
            else
            {
                txttir.Enabled = false;
                txttir.Text = "0";
            }
        }

        private void chckek_CheckedChanged(object sender, EventArgs e)
        {
            if (chckek.Checked == true)
            {
                txtkek.Enabled = true;
                txtkek.Text = "";
                txtkek.Focus();
            }
            else
            {
                txtkek.Enabled = false;
                txtkek.Text = "0";
            }
        }

        private void chclok_CheckedChanged(object sender, EventArgs e)
        {
            if (chclok.Checked == true)
            {
                txtlok.Enabled = true;
                txtlok.Text = "";
                txtlok.Focus();
            }
            else
            {
                txtlok.Enabled = false;
                txtlok.Text = "0";
            }
        }

        private void chcmuf_CheckedChanged(object sender, EventArgs e)
        {
            if (chcmuf.Checked == true)
            {
                txtmuf.Enabled = true;
                txtmuf.Text = "";
                txtmuf.Focus();
            }
            else
            {
                txtmuf.Enabled = false;
                txtmuf.Text = "0";
            }
        }

        private void chcpan_CheckedChanged(object sender, EventArgs e)
        {
            if (chcpan.Checked == true)
            {
                txtpan.Enabled = true;
                txtpan.Text = "";
                txtpan.Focus();
            }
            else
            {
                txtpan.Enabled = false;
                txtpan.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (chckhv.Checked == true)
            {
                txtkhv.Enabled = true;
                txtkhv.Text = "";
                txtkhv.Focus();
            }
            else
            {
                txtkhv.Enabled = false;
                txtkhv.Text = "0";
            }
        }

        private void chccay_CheckedChanged(object sender, EventArgs e)
        {
            if (chccay.Checked == true)
            {
                txtcay.Enabled = true;
                txtcay.Text = "";
                txtcay.Focus();
            }
            else
            {
                txtcay.Enabled = false;
                txtcay.Text = "0";
            }
        }

        private void chckol_CheckedChanged(object sender, EventArgs e)
        {
            if (chckol.Checked == true)
            {
                txtkol.Enabled = true;
                txtkol.Text = "";
                txtkol.Focus();
            }
            else
            {
                txtkol.Enabled = false;
                txtkol.Text = "0";
            }
        }

        private void chcmyv_CheckedChanged(object sender, EventArgs e)
        {
            if (chcmyv.Checked == true)
            {
                txtmyv.Enabled = true;
                txtmyv.Text = "";
                txtmyv.Focus();
            }
            else
            {
                txtmyv.Enabled = false;
                txtmyv.Text = "0";
            }
        }

        private void chcsu_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsu.Checked == true)
            {
                txtsu.Enabled = true;
                txtsu.Text = "";
                txtsu.Focus();
            }
            else
            {
                txtsu.Enabled = false;
                txtsu.Text = "0";
            }
        }

        private void chcvnl_CheckedChanged(object sender, EventArgs e)
        {
            if (chcvnl.Checked == true)
            {
                txtvnl.Enabled = true;
                txtvnl.Text = "";
                txtvnl.Focus();
            }
            else
            {
                txtvnl.Enabled = false;
                txtvnl.Text = "0";
            }
        }

        private void chcik_CheckedChanged(object sender, EventArgs e)
        {
            if (chcik.Checked == true)
            {
                txtcik.Enabled = true;
                txtcik.Text = "";
                txtcik.Focus();
            }
            else
            {
                txtcik.Enabled = false;
                txtcik.Text = "0";
            }
        }

        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdeme.Text == "Nakit")
            {
                txtnakitodeme.Enabled = true;
                txtnakitodeme.Text = "0";
                txtnakitodeme.Focus();
            }
            else
            {
                txtnakitodeme.Enabled = false;
                txtnakitodeme.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] fiyattoplam = new double[22];
            fiyattoplam[0] = Convert.ToDouble(txtpatates.Text) * patatesfiyat;
            fiyattoplam[1] = Convert.ToDouble(txtsalata.Text) * salatafiyat;
            fiyattoplam[2] = Convert.ToDouble(txtburger.Text) * hamburgerfiyat;
            fiyattoplam[3] = Convert.ToDouble(txtsogan.Text) * soganhalkafiyat;
            fiyattoplam[4] = Convert.ToDouble(txtton.Text) * tonsalatafiyat;
            fiyattoplam[5] = Convert.ToDouble(txttons.Text) * tonsandvicfiyat;
            fiyattoplam[6] = Convert.ToDouble(txtislak.Text) * islakburgerfiyat;
            fiyattoplam[7] = Convert.ToDouble(txttvk.Text) * tavuksandvicfiyat;
            fiyattoplam[8] = Convert.ToDouble(txttir.Text) * tiramisufiyat;
            fiyattoplam[9] = Convert.ToDouble(txtkek.Text) * cheesecakefiyat;
            fiyattoplam[10] = Convert.ToDouble(txtlok.Text) * lokmafiyat;
            fiyattoplam[11] = Convert.ToDouble(txtmuf.Text) * muffinfiyat;
            fiyattoplam[12] = Convert.ToDouble(txtpan.Text) * pankekfiyat;
            fiyattoplam[13] = Convert.ToDouble(txtcay.Text) * cayfiyat;
            fiyattoplam[14] = Convert.ToDouble(txtkhv.Text) * kahvefiyat;
            fiyattoplam[15] = Convert.ToDouble(txtkol.Text) * kolafiyat;
            fiyattoplam[16] = Convert.ToDouble(txtmyv.Text) * meyvesuyufiyat;
            fiyattoplam[17] = Convert.ToDouble(txtsu.Text) * sufiyat;
            fiyattoplam[18] = Convert.ToDouble(txtvnl.Text) * vanilyashakefiyat;
            fiyattoplam[19] = Convert.ToDouble(txtcik.Text) * cikolatashakefiyat;
            fiyattoplam[20] = Convert.ToDouble(txtclk.Text) * cilekshakefiyat;
            fiyattoplam[21] = Convert.ToDouble(txtorm.Text) * ormanmeyveshakefiyat;

            double maliyet, paraustu;
            if (cmbOdeme.Text == "Nakit")
            {
                kdvsizToplam = fiyattoplam[0] + fiyattoplam[1] + fiyattoplam[2] + fiyattoplam[3] + fiyattoplam[4] +
                    fiyattoplam[5] + fiyattoplam[6] + fiyattoplam[7] + fiyattoplam[8] + fiyattoplam[9] +
                    fiyattoplam[10] + fiyattoplam[11] + fiyattoplam[12] + fiyattoplam[13] + fiyattoplam[14] +
                    fiyattoplam[15] + fiyattoplam[16] + fiyattoplam[17] + fiyattoplam[18] + fiyattoplam[19] +
                    fiyattoplam[20] + fiyattoplam[21];
                txtvergisiz.Text = Convert.ToString(kdvsizToplam);
                iVergi = (kdvsizToplam * vergioranı) / 100;
                txtvergi.Text = Convert.ToString(iVergi);
                iToplam = (kdvsizToplam + iVergi);
                txttoplam.Text = Convert.ToString(iToplam);
                paraustu = Convert.ToDouble(txtnakitodeme.Text);
                maliyet = paraustu - (iVergi + iToplam);
                txtpru.Text = Convert.ToString(maliyet);
                /* txtpru.Text = string.Format()*/
            }
            else
            {
                kdvsizToplam = fiyattoplam[0] + fiyattoplam[1] + fiyattoplam[2] + fiyattoplam[3] + fiyattoplam[4] +
                    fiyattoplam[5] + fiyattoplam[6] + fiyattoplam[7] + fiyattoplam[8] + fiyattoplam[9] +
                    fiyattoplam[10] + fiyattoplam[11] + fiyattoplam[12] + fiyattoplam[13] + fiyattoplam[14] +
                    fiyattoplam[15] + fiyattoplam[16] + fiyattoplam[17] + fiyattoplam[18] + fiyattoplam[19] +
                    fiyattoplam[20] + fiyattoplam[21];
                txtvergisiz.Text = Convert.ToString(kdvsizToplam);
                iVergi = (kdvsizToplam * vergioranı) / 100;
                txtvergi.Text = Convert.ToString(iVergi);
                iToplam = (kdvsizToplam + iVergi);
                txttoplam.Text = Convert.ToString(iToplam);
            }
        }
        double[,] masalar = new double[10, 28];
        private void button1_Click_1(object sender, EventArgs e)
        {
            int masano = comboBox2.SelectedIndex;
            /*MessageBox.Show(masano.ToString());*/
            if (masano < 10 && masano >= 0)
            {
                masalar[masano, 0] = Convert.ToDouble(txtpatates.Text);
                masalar[masano, 1] = Convert.ToDouble(txtsalata.Text);
                masalar[masano, 2] = Convert.ToDouble(txtburger.Text);
                masalar[masano, 3] = Convert.ToDouble(txtsogan.Text);
                masalar[masano, 4] = Convert.ToDouble(txtton.Text);
                masalar[masano, 5] = Convert.ToDouble(txttons.Text);
                masalar[masano, 6] = Convert.ToDouble(txtislak.Text);
                masalar[masano, 7] = Convert.ToDouble(txtsand.Text);
                masalar[masano, 8] = Convert.ToDouble(txttvk.Text);
                masalar[masano, 9] = Convert.ToDouble(txttir.Text);
                masalar[masano, 10] = Convert.ToDouble(txtkek.Text);
                masalar[masano, 11] = Convert.ToDouble(txtlok.Text);
                masalar[masano, 12] = Convert.ToDouble(txtmuf.Text);
                masalar[masano, 13] = Convert.ToDouble(txtpan.Text);
                masalar[masano, 14] = Convert.ToDouble(txtcay.Text);
                masalar[masano, 15] = Convert.ToDouble(txtkhv.Text);
                masalar[masano, 16] = Convert.ToDouble(txtkol.Text);
                masalar[masano, 17] = Convert.ToDouble(txtmyv.Text);
                masalar[masano, 18] = Convert.ToDouble(txtsu.Text);
                masalar[masano, 19] = Convert.ToDouble(txtvnl.Text);
                masalar[masano, 20] = Convert.ToDouble(txtcik.Text);
                masalar[masano, 21] = Convert.ToDouble(txtclk.Text);
                masalar[masano, 22] = Convert.ToDouble(txtorm.Text);
                masalar[masano, 23] = Convert.ToDouble(txtpru.Text);
                masalar[masano, 24] = Convert.ToDouble(txtvergi.Text);
                masalar[masano, 25] = Convert.ToDouble(txtvergisiz.Text);
                masalar[masano, 26] = Convert.ToDouble(txttoplam.Text);
                masalar[masano, 27] = cmbOdeme.SelectedIndex;                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int masano = comboBox2.SelectedIndex;
            if (comboBox2.SelectedIndex < 10 && comboBox2.SelectedIndex >= 0)
            {
                txtpatates.Text = masalar[masano, 0].ToString();
                txtsalata.Text = masalar[masano, 1].ToString();
                txtburger.Text = masalar[masano, 2].ToString();
                txtsogan.Text = masalar[masano, 3].ToString();
                txtton.Text = masalar[masano, 4].ToString();
                txttons.Text = masalar[masano, 5].ToString();
                txtislak.Text = masalar[masano, 6].ToString();
                txtsand.Text = masalar[masano, 7].ToString();
                txttvk.Text = masalar[masano, 8].ToString();
                txttir.Text = masalar[masano, 9].ToString();
                txtkek.Text = masalar[masano, 10].ToString();
                txtlok.Text = masalar[masano, 11].ToString();
                txtmuf.Text = masalar[masano, 12].ToString();
                txtpan.Text = masalar[masano, 13].ToString();
                txtcay.Text = masalar[masano, 14].ToString();
                txtkhv.Text = masalar[masano, 15].ToString();
                txtkol.Text = masalar[masano, 16].ToString();
                txtmyv.Text = masalar[masano, 17].ToString();
                txtsu.Text = masalar[masano, 18].ToString();
                txtvnl.Text = masalar[masano, 19].ToString();
                txtcik.Text = masalar[masano, 20].ToString();
                txtclk.Text = masalar[masano, 21].ToString();
                txtorm.Text = masalar[masano, 22].ToString();
                txtpru.Text = masalar[masano, 23].ToString();
                txtvergi.Text = masalar[masano, 24].ToString();
                txtvergisiz.Text = masalar[masano, 25].ToString();
                txttoplam.Text = masalar[masano, 26].ToString();
                cmbOdeme.SelectedIndex = Convert.ToInt16(masalar[masano, 27]);
            }            
        }

        private void chcclk_CheckedChanged(object sender, EventArgs e)
        {
            if (chcclk.Checked == true)
            {
                txtclk.Enabled = true;
                txtclk.Text = "";
                txtclk.Focus();
            }
            else
            {
                txtclk.Enabled = false;
                txtclk.Text = "0";
            }
        }

        private void chcorm_CheckedChanged(object sender, EventArgs e)
        {
            if (chcorm.Checked == true)
            {
                txtorm.Enabled = true;
                txtorm.Text = "";
                txtorm.Focus();
            }
            else
            {
                txtorm.Enabled = false;
                txtorm.Text = "0";
            }
        }
    }
}


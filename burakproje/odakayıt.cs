using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burakproje
{
    public partial class odakayıt : Form
    {
        public odakayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3GIB9O5;Initial Catalog=projeotel;Integrated Security=True;Encrypt=False");


        public string tc, ad, adres, soyad, tel, tarih, cinsiyet;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mkayıt frm = new mkayıt();
            frm.Show();
            this.Close();
        }





        //private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        //{

        //    if (e.KeyChar == '.')
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //    }

        //}

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            yemekkontrol.Text = "0";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    odakontrol frm = new odakontrol();
        //    frm.Show();
        //    this.Close();
        //}

        bool tckontrol = false;

        void tckontrolsc()
        {
            baglanti.Open();    
            SqlCommand tck = new SqlCommand("SELECT * FROM müsteriler WHERE mtc=@tc", baglanti);
            tck.Parameters.AddWithValue("@tc", tc);
            SqlDataReader ikra = tck.ExecuteReader();

            if (ikra.Read()) 
            
            {
                tckontrol = true;
            }
            else

            { tckontrol = false; }
            baglanti.Close();

        }

        


        bool datekontrol = false;

        void datekontrolsc()
        {
            baglanti.Open();
            SqlCommand datek = new SqlCommand("SELECT * FROM odakayıt WHERE odano=@odano ", baglanti);
            datek.Parameters.AddWithValue("@odano", textBox3.Text);
            SqlDataReader hazır = datek.ExecuteReader();

            if (hazır.Read())

            {
                datekontrol = true;
               
            }
            else

            { datekontrol = false; }
            baglanti.Close();

        }

        private void yemekkontrol_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy/HH:mm";
            
            int ucret;

            DateTime kcktarih =Convert.ToDateTime(dateTimePicker1.Value);
            DateTime byktarih = Convert.ToDateTime(dateTimePicker2.Value);

            TimeSpan Sonuc = byktarih - kcktarih;

            ucrettext.Text = Sonuc.TotalDays.ToString();

            if (yemekkontrol.Text =="1")
            {
                ucret = (int)(Convert.ToInt32(ucrettext.Text) * 1000 * 1.25);
                txucret.Text = ucret.ToString();


            }
            else
            {
                ucret = Convert.ToInt32(ucrettext.Text) * 1000;
                txucret.Text = ucret.ToString();
            }

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = " ";
            }

        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = " ";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = "10";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = "11";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "12";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = "13";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "14";

        }
         
        private void odakayıt_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from odakayıt", baglanti);
            //komut.Parameters.AddWithValue("@odano", textBox3.Text);
            //SqlCommand komut = new SqlCommand("SELECT mtc,odano FROM odakayıt", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku.HasRows == true)

                {
                    //MessageBox.Show(oku["odano"].ToString());

                    if (oku["odano"].ToString() == "1")
                    {
                        button18.BackColor = Color.Red;

                    }
         


                    if (oku["odano"].ToString() == "2")
                    {
                        button16.BackColor = Color.Red;

                    }
           

                    if (oku["odano"].ToString() == "3")
                    {
                        button3.BackColor = Color.Red;

                    }
                 

                    if (oku["odano"].ToString() == "4")
                    {
                        button4.BackColor = Color.Red;

                    }
              

                    if (oku["odano"].ToString() == "5")
                    {
                        button5.BackColor = Color.Red;

                    }
                

                    if (oku["odano"].ToString() == "6")
                    {
                        button6.BackColor = Color.Red;

                    }
               
                    if (oku["odano"].ToString() == "7")
                    {
                        button7.BackColor = Color.Red;

                    }
               

                    if (oku["odano"].ToString() == "8")
                    {
                        button8.BackColor = Color.Red;

                    }
                

                    if (oku["odano"].ToString() == "9")
                    {
                        button9.BackColor = Color.Red;

                    }
               

                    if (oku["odano"].ToString() == "10")
                    {
                        button10.BackColor = Color.Red;

                    }
                 

                    if (oku["odano"].ToString() == "11")
                    {
                        button11.BackColor = Color.Red;

                    }
               

                    if (oku["odano"].ToString() == "12")
                    {
                        button12.BackColor = Color.Red;

                    }
                

                    if (oku["odano"].ToString() == "13")
                    {
                        button13.BackColor = Color.Red;

                    }
                

                    if (oku["odano"].ToString() == "14")
                    {
                        button14.BackColor = Color.Red;

                    }
                


                }
            }
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("select * from odakayıt", baglanti);
            ////komut.Parameters.AddWithValue("@odano", textBox3.Text);
            ////SqlCommand komut = new SqlCommand("SELECT mtc,odano FROM odakayıt", baglanti);

            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{
            //    if (oku.HasRows == true)

            //{
            //        //MessageBox.Show(oku["odano"].ToString());

            //        if (oku["odano"].ToString() == "1")
            //        {
            //            button18.BackColor = Color.Red;

            //        }
            //        else
            //        {
            //            button18.BackColor = Color.Green;
            //        }

            //    }
            //}
            //baglanti.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy/HH:mm";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dateTimePicker2.Text != " " && dateTimePicker1.Text != " " && textBox3.Text != "")
            {
                tckontrolsc();
                datekontrolsc();
                if (tckontrol == false && datekontrol == false)
                {
                    baglanti.Open();
                    SqlCommand insert = new SqlCommand("INSERT INTO müsteriler (mtc,mad,msoyad,mcinsiyet,mDogumTarihi,mtel,madres) VALUES (@mtc,@mad,@msoyad,@mcinsiyet,@mDogumTarihi,@mtel,@madres)", baglanti);
                    insert.Parameters.AddWithValue("@mtc", tc);
                    insert.Parameters.AddWithValue("@mad", ad);
                    insert.Parameters.AddWithValue("@msoyad", soyad);
                    insert.Parameters.AddWithValue("@mcinsiyet", cinsiyet);
                    insert.Parameters.AddWithValue("@mDogumTarihi", tarih);
                    insert.Parameters.AddWithValue("@mtel", tel);
                    insert.Parameters.AddWithValue("@madres", adres);
                    insert.ExecuteNonQuery();
                    SqlCommand odag = new SqlCommand("INSERT INTO odakayıt (mtc,GTarih,CTarih,Yemek,odano,ucret) VALUES (@mtc,@GTarih,@CTarih,@Yemek,@odano,@ucret)", baglanti);
                    odag.Parameters.AddWithValue("@mtc", tc);
                    odag.Parameters.AddWithValue("@GTarih", dateTimePicker1.Value);
                    odag.Parameters.AddWithValue("@CTarih", dateTimePicker2.Value);
                    odag.Parameters.AddWithValue("@Yemek", yemekkontrol.Text);
                    odag.Parameters.AddWithValue("@odano", textBox3.Text);
                    odag.Parameters.AddWithValue("@ucret", txucret.Text);
                    odag.ExecuteNonQuery();
                    baglanti.Close();
                    clear();
                    MessageBox.Show("Kayıt İşlemi Yapıldı!");                                                                                      
                    mkayıt frm = new mkayıt();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu Kimlik Numarası zaten kayıtlı Veya Oda Dolu!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz!");
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void clearbutton2_Click_1(object sender, EventArgs e)
        {

            //dateTimePicker1.Value = " ";
            //dateTimePicker2.Text = " ";
            textBox3.Text = "";
            yemekkontrol.Text = "0";
            radioButton2.Checked = true;
            radioButton1.Checked = false;
            dateTimePicker1.Focus();
        }

        void clear()
        {
            //dateTimePicker1.Text = " ";
            //dateTimePicker2.Text = " ";
            textBox3.Text = "";
            yemekkontrol.Text = "0";
            radioButton2.Checked = true;
            radioButton1.Checked = false;
            dateTimePicker1.Focus();

        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            yemekkontrol.Text = "1";

        }

        //private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '.')
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //    }

        //}

 
    }
}

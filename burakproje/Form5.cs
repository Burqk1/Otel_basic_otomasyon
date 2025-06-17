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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3GIB9O5;Initial Catalog=projeotel;Integrated Security=True;Encrypt=False");

        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from odakayıt", baglanti);
            SqlDataReader okus = komut2.ExecuteReader();

            while (okus.Read())
            {
                if (okus.HasRows == true)
                {
                    //MessageBox.Show(oku["odano"].ToString());

                    if (okus["odano"].ToString() == "1")
                    {
                        button18.BackColor = Color.Red;

                    }



                    if (okus["odano"].ToString() == "2")
                    {
                        button16.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "3")
                    {
                        button3.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "4")
                    {
                        button4.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "5")
                    {
                        button5.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "6")
                    {
                        button6.BackColor = Color.Red;

                    }

                    if (okus["odano"].ToString() == "7")
                    {
                        button7.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "8")
                    {
                        button8.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "9")
                    {
                        button9.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "10")
                    {
                        button10.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "11")
                    {
                        button11.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "12")
                    {
                        button12.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "13")
                    {
                        button13.BackColor = Color.Red;

                    }


                    if (okus["odano"].ToString() == "14")
                    {
                        button14.BackColor = Color.Red;

                    }
                }
            }
            baglanti.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}

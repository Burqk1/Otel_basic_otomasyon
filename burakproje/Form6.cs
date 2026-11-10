using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace burakproje
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["burakproje.Properties.Settings.projeotelConnectionString"].ConnectionString);

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != " " && textBox1.Text != "")
            {
                baglanti.Open();
                string user;
                string password;
                user = textBox1.Text;
                password = textBox2.Text;

                SqlCommand cmd = new SqlCommand("select * from personeller where kullaniciadi=@user and password=@password",baglanti);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    MessageBox.Show("Hoşgeldiniz "+user+"");
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı adı veya şifre...");


                }
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız");


            }
        }
    }
}

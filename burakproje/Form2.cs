using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace burakproje
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void verigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM mesajlar",baglanti);
            SqlDataReader basla = cmd.ExecuteReader();


            while(basla.Read()) 
            {
                ListViewItem item = new ListViewItem();
                item.Text = basla["id"].ToString();
                item.SubItems.Add(basla["mtc"].ToString());
                item.SubItems.Add(basla["Mesaj"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();

        }

            private void Form2_Load(object sender, EventArgs e)
        {
            verigöster();

        }

        bool tckontrol = false;

        void tckontrolsc()
        {
            baglanti.Open();
            SqlCommand tck = new SqlCommand("SELECT * FROM müsteriler WHERE mtc=@tc", baglanti);
            tck.Parameters.AddWithValue("@tc", textBox2.Text);
            SqlDataReader ikra = tck.ExecuteReader();

            if (ikra.Read())

            {
                tckontrol = true;
            }
            else

            { tckontrol = false; }
            baglanti.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            tckontrolsc();
            if (tckontrol == true)
            {
                if (textBox2.Text != "" && textBox1.Text != "")
                {
                    baglanti.Open();
                    SqlCommand yolla = new SqlCommand("INSERT INTO mesajlar (mtc,Mesaj) VALUES (@mtc,@Mesaj)", baglanti);
                    yolla.Parameters.AddWithValue("@mtc", textBox2.Text);
                    yolla.Parameters.AddWithValue("@Mesaj", textBox1.Text);
                    yolla.ExecuteNonQuery();
                    baglanti.Close();
                    verigöster();
                    clearme();
                     MessageBox.Show("Kayıt İşlemi Yapıldı!");
                
                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz!");
                }
            }
            else
            {
                MessageBox.Show("Sisteme Kayıtlı Böyle Bir Tc Kimlik no yok!");
            }
        }

        void clearme()
        {
            //dateTimePicker1.Text = " ";
            //dateTimePicker2.Text = " ";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox2.Focus();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;

            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

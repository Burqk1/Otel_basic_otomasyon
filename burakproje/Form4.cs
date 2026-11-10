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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;

            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        bool tckontrol = false;

        void tckontrolsc()
        {
            //if (textBox2.Text == "")
            //{
                baglanti.Open();
                SqlCommand tcks = new SqlCommand("SELECT * FROM odakayıt WHERE mtc=@tc", baglanti);
                tcks.Parameters.AddWithValue("@tc", textBox2.Text);
                SqlDataReader ikras = tcks.ExecuteReader();
   
                if (ikras.Read())

                {
                    tckontrol = true;

                }
                else

                { 
                tckontrol = false;

                }
            baglanti.Close();

            //}



        }
        private void verigöster()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM odakayıt", baglanti);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            dt.Fill(db);
            dataGridView1.DataSource = db;
            //while (basla.Read())
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.SubItems.Add(basla["GTarih"].ToString());
            //    item.SubItems.Add(basla["CTarih"].ToString());
            //    item.SubItems.Add(basla["Yemek"].ToString());
            //    item.SubItems.Add(basla["odano"].ToString());
            //    item.SubItems.Add(basla["ucret"].ToString());
            //    item.SubItems.Add(basla["mtc"].ToString());

            //    listView1.Items.Add(item);
            //}
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tckontrolsc();

            if (tckontrol == true)
            {
                if (textBox2.Text != "")
                {
                    baglanti.Open();
                    SqlCommand son = new SqlCommand("SELECT * FROM odakayıt WHERE mtc=@tc", baglanti);
                    son.Parameters.AddWithValue("@tc", textBox2.Text);

                    //SqlCommand cmd = new SqlCommand("SELECT * FROM odakayıt", baglanti);
                    SqlDataAdapter dts = new SqlDataAdapter(son);
                    DataTable dk = new DataTable();
                    dts.Fill(dk);
                    dataGridView1.DataSource = dk;
                    baglanti.Close();

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verigöster();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand son = new SqlCommand("DELETE  FROM odakayıt WHERE mtc=@tc", baglanti);
            son.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["mtc"].Value.ToString());
            son.ExecuteNonQuery();
            baglanti.Close();
            verigöster();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verigöster();

        }
    }
}

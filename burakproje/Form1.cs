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

namespace burakproje
{
    public partial class mkayıt : Form
    {
        public mkayıt()
        {
            InitializeComponent();
        }


        string tc, ad, adres, soyad, tel, tarih, cinsiyet;
        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (txtc.Text != "" && txad.Text != "" && txadres.Text != "" && txsoyad.Text != "" && maskedTextBox1.Text != "" && dateTimePicker1.Text != " ")
            {
                tc = txtc.Text;
                ad = txad.Text.ToUpper();
                soyad = txsoyad.Text.ToUpper();
                adres = txadres.Text;
                tel = maskedTextBox1.Text;
                tarih = dateTimePicker1.Text;
                cinsiyet = cinsiyetkontrol.Text;

                


                odakayıt frm = new odakayıt();
                frm.tc = tc;
                frm.ad = ad;
                frm.soyad = soyad;
                frm.adres = adres;
                frm.tel = tel;
                frm.tarih = tarih;
                frm.cinsiyet = cinsiyet;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz!");
            }

        }


        private void txtc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;

            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void clearbutton1_Click_1(object sender, EventArgs e)
        {
            txtc.Text = "";
            txad.Text = "";
            txadres.Text = "";
            txsoyad.Text = "";
            maskedTextBox1.Text = "";
            //dateTimePicker1.Text = " ";
            cinsiyetkontrol.Text = "Erkek";
            radioerkek.Checked = true;
            radiokadın.Checked = false;
            txtc.Focus();
        }

        private void radioerkek_CheckedChanged_1(object sender, EventArgs e)
        {
            cinsiyetkontrol.Text = "Erkek";

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = " ";
            }



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void radiokadın_CheckedChanged_1(object sender, EventArgs e)
        {
            cinsiyetkontrol.Text = "Kadın";

        }

        private void cinsiyetkontrol_Click(object sender, EventArgs e)
        {

        }

 

        private void txsoyad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void txad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        //private void txtarih_KeyPress_1(object sender, KeyPressEventArgs e)
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

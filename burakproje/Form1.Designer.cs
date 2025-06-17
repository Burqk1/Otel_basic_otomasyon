using System.Windows.Forms;

namespace burakproje
{
    partial class mkayıt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txsoyad = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radiokadın = new System.Windows.Forms.RadioButton();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txadres = new System.Windows.Forms.TextBox();
            this.nextbutton = new System.Windows.Forms.Button();
            this.clearbutton1 = new System.Windows.Forms.Button();
            this.cinsiyetkontrol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::burakproje.Properties.Resources.left_arrow_28_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 46);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(634, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 46);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "OTEL-Müşteri Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtc);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(10, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(201, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri T.C.";
            // 
            // txtc
            // 
            this.txtc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtc.Location = new System.Drawing.Point(13, 27);
            this.txtc.MaxLength = 11;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(185, 26);
            this.txtc.TabIndex = 0;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            this.txtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtc_KeyPress_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txad);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(247, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(180, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Adı";
            // 
            // txad
            // 
            this.txad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txad.Location = new System.Drawing.Point(13, 27);
            this.txad.MaxLength = 50;
            this.txad.Name = "txad";
            this.txad.Size = new System.Drawing.Size(164, 26);
            this.txad.TabIndex = 1;
            this.txad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txad_KeyPress_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txsoyad);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(453, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(214, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Soyadı";
            // 
            // txsoyad
            // 
            this.txsoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txsoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txsoyad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txsoyad.Location = new System.Drawing.Point(13, 27);
            this.txsoyad.MaxLength = 50;
            this.txsoyad.Name = "txsoyad";
            this.txsoyad.Size = new System.Drawing.Size(198, 26);
            this.txsoyad.TabIndex = 1;
            this.txsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txsoyad_KeyPress_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radiokadın);
            this.groupBox4.Controls.Add(this.radioerkek);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox4.Location = new System.Drawing.Point(244, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(183, 67);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri Cinsiyet";
            // 
            // radiokadın
            // 
            this.radiokadın.AutoSize = true;
            this.radiokadın.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiokadın.Location = new System.Drawing.Point(87, 28);
            this.radiokadın.Name = "radiokadın";
            this.radiokadın.Size = new System.Drawing.Size(81, 29);
            this.radiokadın.TabIndex = 1;
            this.radiokadın.Text = "Kadın";
            this.radiokadın.UseVisualStyleBackColor = true;
            this.radiokadın.CheckedChanged += new System.EventHandler(this.radiokadın_CheckedChanged_1);
            // 
            // radioerkek
            // 
            this.radioerkek.AutoSize = true;
            this.radioerkek.Checked = true;
            this.radioerkek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioerkek.Location = new System.Drawing.Point(13, 28);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(80, 29);
            this.radioerkek.TabIndex = 0;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "Erkek";
            this.radioerkek.UseVisualStyleBackColor = true;
            this.radioerkek.CheckedChanged += new System.EventHandler(this.radioerkek_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox5.Location = new System.Drawing.Point(453, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(214, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(2, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maskedTextBox1);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox6.Location = new System.Drawing.Point(10, 136);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(201, 56);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Müşteri Telefon";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 29);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 25);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txadres);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox7.Location = new System.Drawing.Point(244, 136);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(183, 56);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Müşteri Adres";
            // 
            // txadres
            // 
            this.txadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txadres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txadres.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txadres.Location = new System.Drawing.Point(13, 27);
            this.txadres.MaxLength = 100;
            this.txadres.Name = "txadres";
            this.txadres.Size = new System.Drawing.Size(167, 26);
            this.txadres.TabIndex = 1;
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbutton.FlatAppearance.BorderSize = 0;
            this.nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextbutton.Location = new System.Drawing.Point(346, 271);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(241, 43);
            this.nextbutton.TabIndex = 8;
            this.nextbutton.Text = "Sonraki Adım";
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // clearbutton1
            // 
            this.clearbutton1.BackColor = System.Drawing.Color.Brown;
            this.clearbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbutton1.FlatAppearance.BorderSize = 0;
            this.clearbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbutton1.Location = new System.Drawing.Point(99, 271);
            this.clearbutton1.Name = "clearbutton1";
            this.clearbutton1.Size = new System.Drawing.Size(241, 43);
            this.clearbutton1.TabIndex = 9;
            this.clearbutton1.Text = "Temizle";
            this.clearbutton1.UseVisualStyleBackColor = false;
            this.clearbutton1.Click += new System.EventHandler(this.clearbutton1_Click_1);
            // 
            // cinsiyetkontrol
            // 
            this.cinsiyetkontrol.AutoSize = true;
            this.cinsiyetkontrol.Location = new System.Drawing.Point(12, 345);
            this.cinsiyetkontrol.Name = "cinsiyetkontrol";
            this.cinsiyetkontrol.Size = new System.Drawing.Size(35, 13);
            this.cinsiyetkontrol.TabIndex = 10;
            this.cinsiyetkontrol.Text = "Erkek";
            this.cinsiyetkontrol.Visible = false;
            this.cinsiyetkontrol.Click += new System.EventHandler(this.cinsiyetkontrol_Click);
            // 
            // mkayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(674, 367);
            this.Controls.Add(this.cinsiyetkontrol);
            this.Controls.Add(this.clearbutton1);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mkayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_exit;
        private GroupBox groupBox1;
        private TextBox txtc;
        private GroupBox groupBox2;
        private TextBox txad;
        private GroupBox groupBox3;
        private TextBox txsoyad;
        private GroupBox groupBox4;
        private RadioButton radioerkek;
        private RadioButton radiokadın;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox txadres;
        private Button nextbutton;
        private Button clearbutton1;
        private Label cinsiyetkontrol;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
    }
}


namespace otomasyon
{
    partial class teknik_servis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teknik_servis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.combo_personel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_arıza_çözüm = new System.Windows.Forms.TextBox();
            this.tb_arıza_tanım = new System.Windows.Forms.TextBox();
            this.tb_cihaz = new System.Windows.Forms.TextBox();
            this.tb_talep = new System.Windows.Forms.TextBox();
            this.tb_m_telefon = new System.Windows.Forms.TextBox();
            this.tb_m_soyadi = new System.Windows.Forms.TextBox();
            this.tb_m_adi = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şu Anda Teknik Servis Biriminde Bulunan Cihazlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.combo_personel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_arıza_çözüm);
            this.groupBox1.Controls.Add(this.tb_arıza_tanım);
            this.groupBox1.Controls.Add(this.tb_cihaz);
            this.groupBox1.Controls.Add(this.tb_talep);
            this.groupBox1.Controls.Add(this.tb_m_telefon);
            this.groupBox1.Controls.Add(this.tb_m_soyadi);
            this.groupBox1.Controls.Add(this.tb_m_adi);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Arıza Girişi";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(66, 262);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(158, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Teknik Servise Kaydını Yap";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // combo_personel
            // 
            this.combo_personel.FormattingEnabled = true;
            this.combo_personel.Items.AddRange(new object[] {
            "Personel Seçiniz"});
            this.combo_personel.Location = new System.Drawing.Point(134, 159);
            this.combo_personel.Name = "combo_personel";
            this.combo_personel.Size = new System.Drawing.Size(147, 21);
            this.combo_personel.TabIndex = 5;
            this.combo_personel.Text = "Personel Seçiniz";
            this.combo_personel.TextChanged += new System.EventHandler(this.combo_personel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cihaz Bilgisi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "İlgilenecek Personel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Arıza Talebi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Uygulanacak Çözüm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Arızanın Tanımı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı";
            // 
            // tb_arıza_çözüm
            // 
            this.tb_arıza_çözüm.Location = new System.Drawing.Point(134, 212);
            this.tb_arıza_çözüm.Name = "tb_arıza_çözüm";
            this.tb_arıza_çözüm.Size = new System.Drawing.Size(147, 20);
            this.tb_arıza_çözüm.TabIndex = 8;
            // 
            // tb_arıza_tanım
            // 
            this.tb_arıza_tanım.Location = new System.Drawing.Point(134, 186);
            this.tb_arıza_tanım.Name = "tb_arıza_tanım";
            this.tb_arıza_tanım.Size = new System.Drawing.Size(147, 20);
            this.tb_arıza_tanım.TabIndex = 7;
            // 
            // tb_cihaz
            // 
            this.tb_cihaz.Location = new System.Drawing.Point(134, 133);
            this.tb_cihaz.Name = "tb_cihaz";
            this.tb_cihaz.Size = new System.Drawing.Size(147, 20);
            this.tb_cihaz.TabIndex = 4;
            // 
            // tb_talep
            // 
            this.tb_talep.Location = new System.Drawing.Point(134, 107);
            this.tb_talep.Name = "tb_talep";
            this.tb_talep.Size = new System.Drawing.Size(147, 20);
            this.tb_talep.TabIndex = 3;
            // 
            // tb_m_telefon
            // 
            this.tb_m_telefon.Location = new System.Drawing.Point(134, 81);
            this.tb_m_telefon.Name = "tb_m_telefon";
            this.tb_m_telefon.Size = new System.Drawing.Size(147, 20);
            this.tb_m_telefon.TabIndex = 2;
            // 
            // tb_m_soyadi
            // 
            this.tb_m_soyadi.Location = new System.Drawing.Point(134, 55);
            this.tb_m_soyadi.Name = "tb_m_soyadi";
            this.tb_m_soyadi.Size = new System.Drawing.Size(147, 20);
            this.tb_m_soyadi.TabIndex = 1;
            // 
            // tb_m_adi
            // 
            this.tb_m_adi.Location = new System.Drawing.Point(134, 29);
            this.tb_m_adi.Name = "tb_m_adi";
            this.tb_m_adi.Size = new System.Drawing.Size(147, 20);
            this.tb_m_adi.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(785, 322);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(161, 23);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Cihazın Çıkışını Yap";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::otomasyon.Properties.Resources.tek;
            this.pictureBox1.Location = new System.Drawing.Point(483, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // teknik_servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teknik_servis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis Yönetim Penceresi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.teknik_servis_FormClosed);
            this.Load += new System.EventHandler(this.teknik_servis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox combo_personel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_arıza_çözüm;
        private System.Windows.Forms.TextBox tb_arıza_tanım;
        private System.Windows.Forms.TextBox tb_cihaz;
        private System.Windows.Forms.TextBox tb_talep;
        private System.Windows.Forms.TextBox tb_m_telefon;
        private System.Windows.Forms.TextBox tb_m_soyadi;
        private System.Windows.Forms.TextBox tb_m_adi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
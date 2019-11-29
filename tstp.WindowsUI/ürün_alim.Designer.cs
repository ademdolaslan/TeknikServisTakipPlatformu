namespace otomasyon
{
    partial class ürün_alim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ürün_alim));
            this.combo_personel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ürün_ad = new System.Windows.Forms.TextBox();
            this.tb_ürün_marka = new System.Windows.Forms.TextBox();
            this.tb_ürün_model = new System.Windows.Forms.TextBox();
            this.tb_ürün_stok = new System.Windows.Forms.TextBox();
            this.tb_ürün_fiyat = new System.Windows.Forms.TextBox();
            this.combo_tür = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_firma_telefon = new System.Windows.Forms.TextBox();
            this.tb_firma_adres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_firma_ad = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_personel
            // 
            this.combo_personel.FormattingEnabled = true;
            this.combo_personel.Location = new System.Drawing.Point(131, 188);
            this.combo_personel.Name = "combo_personel";
            this.combo_personel.Size = new System.Drawing.Size(121, 21);
            this.combo_personel.TabIndex = 6;
            this.combo_personel.SelectedIndexChanged += new System.EventHandler(this.combo_personel_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 178);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Modeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Fiyatı (TL)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ürün Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "İlgilenen Personel";
            // 
            // tb_ürün_ad
            // 
            this.tb_ürün_ad.Location = new System.Drawing.Point(131, 16);
            this.tb_ürün_ad.Name = "tb_ürün_ad";
            this.tb_ürün_ad.Size = new System.Drawing.Size(121, 20);
            this.tb_ürün_ad.TabIndex = 0;
            // 
            // tb_ürün_marka
            // 
            this.tb_ürün_marka.Location = new System.Drawing.Point(131, 44);
            this.tb_ürün_marka.Name = "tb_ürün_marka";
            this.tb_ürün_marka.Size = new System.Drawing.Size(121, 20);
            this.tb_ürün_marka.TabIndex = 1;
            // 
            // tb_ürün_model
            // 
            this.tb_ürün_model.Location = new System.Drawing.Point(131, 73);
            this.tb_ürün_model.Name = "tb_ürün_model";
            this.tb_ürün_model.Size = new System.Drawing.Size(121, 20);
            this.tb_ürün_model.TabIndex = 2;
            // 
            // tb_ürün_stok
            // 
            this.tb_ürün_stok.Location = new System.Drawing.Point(131, 100);
            this.tb_ürün_stok.Name = "tb_ürün_stok";
            this.tb_ürün_stok.Size = new System.Drawing.Size(121, 20);
            this.tb_ürün_stok.TabIndex = 3;
            // 
            // tb_ürün_fiyat
            // 
            this.tb_ürün_fiyat.Location = new System.Drawing.Point(131, 128);
            this.tb_ürün_fiyat.Name = "tb_ürün_fiyat";
            this.tb_ürün_fiyat.Size = new System.Drawing.Size(121, 20);
            this.tb_ürün_fiyat.TabIndex = 4;
            // 
            // combo_tür
            // 
            this.combo_tür.FormattingEnabled = true;
            this.combo_tür.Items.AddRange(new object[] {
            "Monitör",
            "Klavye",
            "Mause",
            "Camera",
            "Hoparlör",
            "Modem",
            "Konsol",
            "Anakart",
            "Güç Kaynağı",
            "İşlemci",
            "Ekran Kartı",
            "RAM",
            "Harddisk",
            "FAN",
            "Ses Kartı",
            "Harici",
            "CD",
            "DVD",
            "Çanta",
            "Soğutucu",
            "Silikon Kılıf"});
            this.combo_tür.Location = new System.Drawing.Point(131, 157);
            this.combo_tür.Name = "combo_tür";
            this.combo_tür.Size = new System.Drawing.Size(121, 21);
            this.combo_tür.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Firma İsmi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Firma Telefonu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Firma Adresi";
            // 
            // tb_firma_telefon
            // 
            this.tb_firma_telefon.Location = new System.Drawing.Point(408, 44);
            this.tb_firma_telefon.Name = "tb_firma_telefon";
            this.tb_firma_telefon.Size = new System.Drawing.Size(149, 20);
            this.tb_firma_telefon.TabIndex = 8;
            // 
            // tb_firma_adres
            // 
            this.tb_firma_adres.Location = new System.Drawing.Point(408, 76);
            this.tb_firma_adres.Name = "tb_firma_adres";
            this.tb_firma_adres.Size = new System.Drawing.Size(149, 59);
            this.tb_firma_adres.TabIndex = 9;
            this.tb_firma_adres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tüm Ürünler";
            // 
            // tb_firma_ad
            // 
            this.tb_firma_ad.Location = new System.Drawing.Point(408, 16);
            this.tb_firma_ad.Name = "tb_firma_ad";
            this.tb_firma_ad.Size = new System.Drawing.Size(149, 20);
            this.tb_firma_ad.TabIndex = 7;
            this.tb_firma_ad.Leave += new System.EventHandler(this.tb_firma_ad_Leave);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(408, 160);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(149, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Alım Yap";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // ürün_alim
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 438);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_firma_ad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_firma_adres);
            this.Controls.Add(this.tb_firma_telefon);
            this.Controls.Add(this.combo_tür);
            this.Controls.Add(this.tb_ürün_fiyat);
            this.Controls.Add(this.tb_ürün_stok);
            this.Controls.Add(this.tb_ürün_model);
            this.Controls.Add(this.tb_ürün_marka);
            this.Controls.Add(this.tb_ürün_ad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_personel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ürün_alim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ürün_alim_FormClosed);
            this.Load += new System.EventHandler(this.ürün_alim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_personel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ürün_ad;
        private System.Windows.Forms.TextBox tb_ürün_marka;
        private System.Windows.Forms.TextBox tb_ürün_model;
        private System.Windows.Forms.TextBox tb_ürün_stok;
        private System.Windows.Forms.TextBox tb_ürün_fiyat;
        private System.Windows.Forms.ComboBox combo_tür;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_firma_telefon;
        private System.Windows.Forms.RichTextBox tb_firma_adres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_firma_ad;
        private System.Windows.Forms.Button btn_submit;
    }
}
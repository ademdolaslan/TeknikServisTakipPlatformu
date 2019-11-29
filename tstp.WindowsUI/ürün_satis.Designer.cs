namespace otomasyon
{
    partial class ürün_satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ürün_satis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_musteri_adi = new System.Windows.Forms.TextBox();
            this.tb_musteri_soyadi = new System.Windows.Forms.TextBox();
            this.tb_musteri_telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_personel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(139, 461);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(167, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Satışı Tamamla";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Telefonu";
            // 
            // tb_musteri_adi
            // 
            this.tb_musteri_adi.Location = new System.Drawing.Point(139, 331);
            this.tb_musteri_adi.Name = "tb_musteri_adi";
            this.tb_musteri_adi.Size = new System.Drawing.Size(167, 20);
            this.tb_musteri_adi.TabIndex = 0;
            // 
            // tb_musteri_soyadi
            // 
            this.tb_musteri_soyadi.Location = new System.Drawing.Point(139, 356);
            this.tb_musteri_soyadi.Name = "tb_musteri_soyadi";
            this.tb_musteri_soyadi.Size = new System.Drawing.Size(167, 20);
            this.tb_musteri_soyadi.TabIndex = 1;
            // 
            // tb_musteri_telefon
            // 
            this.tb_musteri_telefon.Location = new System.Drawing.Point(139, 382);
            this.tb_musteri_telefon.Name = "tb_musteri_telefon";
            this.tb_musteri_telefon.Size = new System.Drawing.Size(167, 20);
            this.tb_musteri_telefon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adet Giriniz";
            // 
            // combo_personel
            // 
            this.combo_personel.FormattingEnabled = true;
            this.combo_personel.Location = new System.Drawing.Point(139, 434);
            this.combo_personel.Name = "combo_personel";
            this.combo_personel.Size = new System.Drawing.Size(167, 21);
            this.combo_personel.TabIndex = 4;
            this.combo_personel.SelectedIndexChanged += new System.EventHandler(this.combo_personel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün satışı yapabilmeniz için yetkili hesapla oturum açmanız gerekmektedir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Listeden ürün seçip satışı tamamla butonuna tıklayınız";
            // 
            // ürün_satis
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_personel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_musteri_telefon);
            this.Controls.Add(this.tb_musteri_soyadi);
            this.Controls.Add(this.tb_musteri_adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ürün_satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satım Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ürün_satis_FormClosed);
            this.Load += new System.EventHandler(this.ürün_satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_musteri_adi;
        private System.Windows.Forms.TextBox tb_musteri_soyadi;
        private System.Windows.Forms.TextBox tb_musteri_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_personel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
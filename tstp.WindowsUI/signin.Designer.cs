namespace otomasyon
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(308, 68);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(131, 20);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(308, 94);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(131, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(308, 120);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(131, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_surname.Location = new System.Drawing.Point(308, 146);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(131, 20);
            this.tb_surname.TabIndex = 3;
            this.tb_surname.TextChanged += new System.EventHandler(this.tb_surname_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Location = new System.Drawing.Point(269, 181);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(80, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Oluşur";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iptal.Location = new System.Drawing.Point(364, 181);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyon.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(50, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // signin
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
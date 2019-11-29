namespace otomasyon
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Location = new System.Drawing.Point(386, 100);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(76, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "GİRİŞ";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_name.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_name.Location = new System.Drawing.Point(310, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(152, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "Kullanıcı Adı Giriniz";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_pass.Location = new System.Drawing.Point(310, 74);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(152, 20);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.Text = "Şifre Giriniz";
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pass.Enter += new System.EventHandler(this.tb_pass_Enter);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(240, 77);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(28, 13);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Şifre";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(240, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Kullanıcı Adı";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(272, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yetkili Bir Kullanıcı Hesabı Oluşturun";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(450, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 566);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 58);
            this.dataGridView1.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(272, 177);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(188, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Standart Bir Kullanıcı Hesabı Oluşturun";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyon.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(47, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


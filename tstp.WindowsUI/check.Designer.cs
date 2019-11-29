namespace otomasyon
{
    partial class check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(check));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_name.Location = new System.Drawing.Point(192, 99);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(84, 17);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Kullanıcı Adı";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_pass.Location = new System.Drawing.Point(192, 125);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(37, 17);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Şifre";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_pass.Location = new System.Drawing.Point(282, 125);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(159, 20);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.Text = "Şifre Giriniz";
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pass.Enter += new System.EventHandler(this.tb_pass_Enter);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_name.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_name.Location = new System.Drawing.Point(282, 99);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(159, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "Kullanıcı Adı Giriniz";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(282, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(365, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "iptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lütfen Yönetici Adınızı Ve Şifrenizi Giriniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::otomasyon.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(32, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // check
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "check";
            this.Load += new System.EventHandler(this.check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace otomasyon
{
    partial class depo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtrele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_parca_no = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrele";
            // 
            // btn_filtrele
            // 
            this.btn_filtrele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filtrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_filtrele.Location = new System.Drawing.Point(12, 6);
            this.btn_filtrele.Name = "btn_filtrele";
            this.btn_filtrele.Size = new System.Drawing.Size(103, 23);
            this.btn_filtrele.TabIndex = 3;
            this.btn_filtrele.Text = "Filtrele";
            this.btn_filtrele.UseVisualStyleBackColor = false;
            this.btn_filtrele.Click += new System.EventHandler(this.btn_filtrele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(64, 62);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(159, 20);
            this.tb_filter.TabIndex = 5;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_remove.Location = new System.Drawing.Point(121, 6);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(103, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Geri Al";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Adına Göre",
            "Ürün Markasına Göre",
            "Ürün Modeline Göre",
            "Ürün Türüne Göre"});
            this.comboBox1.Location = new System.Drawing.Point(64, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search.Location = new System.Drawing.Point(490, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_parca_no
            // 
            this.tb_parca_no.Location = new System.Drawing.Point(599, 8);
            this.tb_parca_no.Name = "tb_parca_no";
            this.tb_parca_no.Size = new System.Drawing.Size(139, 20);
            this.tb_parca_no.TabIndex = 5;
            // 
            // depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 518);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_parca_no);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_filtrele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "depo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.depo_FormClosed);
            this.Load += new System.EventHandler(this.depo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtrele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_parca_no;
    }
}
namespace E_Data
{
    partial class selected
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
            this.kosong = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtptek = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tcust = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fcust = new System.Windows.Forms.TextBox();
            this.hpcust = new System.Windows.Forms.TextBox();
            this.tekcust = new System.Windows.Forms.TextBox();
            this.pcust = new System.Windows.Forms.TextBox();
            this.alcust = new System.Windows.Forms.TextBox();
            this.ncust = new System.Windows.Forms.TextBox();
            this.ketcust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kosong
            // 
            this.kosong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kosong.Location = new System.Drawing.Point(406, 309);
            this.kosong.Margin = new System.Windows.Forms.Padding(2);
            this.kosong.Name = "kosong";
            this.kosong.Size = new System.Drawing.Size(151, 43);
            this.kosong.TabIndex = 51;
            this.kosong.Text = "Edit";
            this.kosong.UseVisualStyleBackColor = true;
            this.kosong.Click += new System.EventHandler(this.kosong_Click);
            // 
            // Print
            // 
            this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Print.Location = new System.Drawing.Point(609, 309);
            this.Print.Margin = new System.Windows.Forms.Padding(2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(141, 43);
            this.Print.TabIndex = 50;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // batal
            // 
            this.batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.batal.Location = new System.Drawing.Point(13, 309);
            this.batal.Margin = new System.Windows.Forms.Padding(2);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(117, 43);
            this.batal.TabIndex = 49;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Keterangan";
            // 
            // dtptek
            // 
            this.dtptek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtptek.Enabled = false;
            this.dtptek.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptek.Location = new System.Drawing.Point(583, 207);
            this.dtptek.Margin = new System.Windows.Forms.Padding(2);
            this.dtptek.MaximumSize = new System.Drawing.Size(3000, 30);
            this.dtptek.MinimumSize = new System.Drawing.Size(76, 30);
            this.dtptek.Name = "dtptek";
            this.dtptek.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtptek.Size = new System.Drawing.Size(150, 30);
            this.dtptek.TabIndex = 42;
            this.dtptek.Value = new System.DateTime(2018, 8, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "No Fax";
            // 
            // tcust
            // 
            this.tcust.Location = new System.Drawing.Point(314, 140);
            this.tcust.Margin = new System.Windows.Forms.Padding(2);
            this.tcust.MaximumSize = new System.Drawing.Size(91, 30);
            this.tcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.tcust.Multiline = true;
            this.tcust.Name = "tcust";
            this.tcust.ReadOnly = true;
            this.tcust.Size = new System.Drawing.Size(151, 30);
            this.tcust.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "/";
            // 
            // fcust
            // 
            this.fcust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcust.Location = new System.Drawing.Point(542, 140);
            this.fcust.Margin = new System.Windows.Forms.Padding(2);
            this.fcust.MaximumSize = new System.Drawing.Size(60001, 30);
            this.fcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.fcust.Multiline = true;
            this.fcust.Name = "fcust";
            this.fcust.ReadOnly = true;
            this.fcust.Size = new System.Drawing.Size(191, 30);
            this.fcust.TabIndex = 38;
            // 
            // hpcust
            // 
            this.hpcust.Location = new System.Drawing.Point(142, 140);
            this.hpcust.Margin = new System.Windows.Forms.Padding(2);
            this.hpcust.MaximumSize = new System.Drawing.Size(91, 30);
            this.hpcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.hpcust.Multiline = true;
            this.hpcust.Name = "hpcust";
            this.hpcust.ReadOnly = true;
            this.hpcust.Size = new System.Drawing.Size(151, 30);
            this.hpcust.TabIndex = 35;
            // 
            // tekcust
            // 
            this.tekcust.Location = new System.Drawing.Point(142, 207);
            this.tekcust.Margin = new System.Windows.Forms.Padding(2);
            this.tekcust.MaximumSize = new System.Drawing.Size(24001, 30);
            this.tekcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.tekcust.Multiline = true;
            this.tekcust.Name = "tekcust";
            this.tekcust.ReadOnly = true;
            this.tekcust.Size = new System.Drawing.Size(303, 30);
            this.tekcust.TabIndex = 41;
            // 
            // pcust
            // 
            this.pcust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcust.Location = new System.Drawing.Point(142, 174);
            this.pcust.Margin = new System.Windows.Forms.Padding(2);
            this.pcust.MaximumSize = new System.Drawing.Size(24001, 30);
            this.pcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.pcust.Multiline = true;
            this.pcust.Name = "pcust";
            this.pcust.ReadOnly = true;
            this.pcust.Size = new System.Drawing.Size(591, 30);
            this.pcust.TabIndex = 39;
            // 
            // alcust
            // 
            this.alcust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alcust.Location = new System.Drawing.Point(142, 46);
            this.alcust.Margin = new System.Windows.Forms.Padding(2);
            this.alcust.MaximumSize = new System.Drawing.Size(24001, 90);
            this.alcust.MinimumSize = new System.Drawing.Size(151, 90);
            this.alcust.Multiline = true;
            this.alcust.Name = "alcust";
            this.alcust.ReadOnly = true;
            this.alcust.Size = new System.Drawing.Size(591, 90);
            this.alcust.TabIndex = 33;
            // 
            // ncust
            // 
            this.ncust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ncust.Location = new System.Drawing.Point(142, 11);
            this.ncust.Margin = new System.Windows.Forms.Padding(2);
            this.ncust.MaximumSize = new System.Drawing.Size(24001, 30);
            this.ncust.MinimumSize = new System.Drawing.Size(151, 30);
            this.ncust.Multiline = true;
            this.ncust.Name = "ncust";
            this.ncust.ReadOnly = true;
            this.ncust.Size = new System.Drawing.Size(591, 30);
            this.ncust.TabIndex = 32;
            // 
            // ketcust
            // 
            this.ketcust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ketcust.Location = new System.Drawing.Point(142, 241);
            this.ketcust.Margin = new System.Windows.Forms.Padding(2);
            this.ketcust.MaximumSize = new System.Drawing.Size(24001, 30);
            this.ketcust.MinimumSize = new System.Drawing.Size(151, 30);
            this.ketcust.Multiline = true;
            this.ketcust.Name = "ketcust";
            this.ketcust.ReadOnly = true;
            this.ketcust.Size = new System.Drawing.Size(591, 30);
            this.ketcust.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tanggal Pasang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Teknisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Produk Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "No HP / Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Alamat Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nama Customer";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(198, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 52;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kosong);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtptek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tcust);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fcust);
            this.Controls.Add(this.hpcust);
            this.Controls.Add(this.tekcust);
            this.Controls.Add(this.pcust);
            this.Controls.Add(this.alcust);
            this.Controls.Add(this.ncust);
            this.Controls.Add(this.ketcust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "selected";
            this.Text = "selected";
            this.Load += new System.EventHandler(this.selected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kosong;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtptek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tcust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fcust;
        private System.Windows.Forms.TextBox hpcust;
        private System.Windows.Forms.TextBox tekcust;
        private System.Windows.Forms.TextBox pcust;
        private System.Windows.Forms.TextBox alcust;
        private System.Windows.Forms.TextBox ncust;
        private System.Windows.Forms.TextBox ketcust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
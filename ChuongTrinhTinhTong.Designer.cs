namespace Chuong4_b1
{
    partial class frmChuongTrinhTinhTong
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
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.texta = new System.Windows.Forms.TextBox();
            this.textb = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.labela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lba.Location = new System.Drawing.Point(124, 35);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(54, 17);
            this.lba.TabIndex = 0;
            this.lba.Text = "Nhap a";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbb.Location = new System.Drawing.Point(124, 81);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(54, 17);
            this.lbb.TabIndex = 1;
            this.lbb.Text = "Nhap b";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb1.Location = new System.Drawing.Point(87, 130);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(102, 17);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Tổng các số từ";
            // 
            // texta
            // 
            this.texta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.texta.Location = new System.Drawing.Point(194, 34);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(90, 23);
            this.texta.TabIndex = 5;
            this.texta.TextChanged += new System.EventHandler(this.texta_TextChanged);
            this.texta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texta_KeyPress);
            // 
            // textb
            // 
            this.textb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textb.Location = new System.Drawing.Point(194, 80);
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(90, 23);
            this.textb.TabIndex = 6;
            this.textb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_KeyPress);
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTong.Location = new System.Drawing.Point(90, 198);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 33);
            this.btnTong.TabIndex = 9;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLamLai.Location = new System.Drawing.Point(258, 198);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 33);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnthoat.Location = new System.Drawing.Point(430, 198);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 33);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labela.Location = new System.Drawing.Point(191, 132);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(0, 17);
            this.labela.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(232, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "đến";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelb.Location = new System.Drawing.Point(283, 132);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(0, 17);
            this.labelb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(320, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "là";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeltong
            // 
            this.labeltong.AutoSize = true;
            this.labeltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labeltong.Location = new System.Drawing.Point(376, 136);
            this.labeltong.Name = "labeltong";
            this.labeltong.Size = new System.Drawing.Size(0, 17);
            this.labeltong.TabIndex = 16;
            // 
            // frmChuongTrinhTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(543, 254);
            this.Controls.Add(this.labeltong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.texta);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Name = "frmChuongTrinhTinhTong";
            this.Text = "ChuongTrinhTinhTong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltong;
    }
}


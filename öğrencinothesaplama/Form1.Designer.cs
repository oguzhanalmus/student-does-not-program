namespace öğrencinothesaplama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mmrmatematik = new System.Windows.Forms.NumericUpDown();
            this.mmrturkce = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mmrbiyoloji = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mmrfizik = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.mmrmatematik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrturkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrbiyoloji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrfizik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematik";
            // 
            // mmrmatematik
            // 
            this.mmrmatematik.Location = new System.Drawing.Point(115, 40);
            this.mmrmatematik.Name = "mmrmatematik";
            this.mmrmatematik.Size = new System.Drawing.Size(120, 20);
            this.mmrmatematik.TabIndex = 1;
            // 
            // mmrturkce
            // 
            this.mmrturkce.Location = new System.Drawing.Point(378, 93);
            this.mmrturkce.Name = "mmrturkce";
            this.mmrturkce.Size = new System.Drawing.Size(120, 20);
            this.mmrturkce.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe";
            // 
            // mmrbiyoloji
            // 
            this.mmrbiyoloji.Location = new System.Drawing.Point(115, 88);
            this.mmrbiyoloji.Name = "mmrbiyoloji";
            this.mmrbiyoloji.Size = new System.Drawing.Size(120, 20);
            this.mmrbiyoloji.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Biyoloji";
            // 
            // mmrfizik
            // 
            this.mmrfizik.Location = new System.Drawing.Point(378, 42);
            this.mmrfizik.Name = "mmrfizik";
            this.mmrfizik.Size = new System.Drawing.Size(120, 20);
            this.mmrfizik.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fizik";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(135, 162);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciAd.TabIndex = 8;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(350, 162);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciSoyadi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci Soyadı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(255, 209);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // liste
            // 
            this.liste.BackColor = System.Drawing.SystemColors.Info;
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(-6, 268);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(550, 82);
            this.liste.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(544, 346);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.mmrfizik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mmrbiyoloji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mmrturkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mmrmatematik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Öğrenci Not Hesaplama Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.mmrmatematik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrturkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrbiyoloji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmrfizik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mmrmatematik;
        private System.Windows.Forms.NumericUpDown mmrturkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mmrbiyoloji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mmrfizik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox liste;
    }
}


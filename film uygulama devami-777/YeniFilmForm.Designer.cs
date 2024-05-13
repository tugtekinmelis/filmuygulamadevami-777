namespace film_uygulama_devami_777
{
    partial class YeniFilmForm
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
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cbOdul = new System.Windows.Forms.CheckBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbResim.Location = new System.Drawing.Point(311, 51);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(173, 245);
            this.pbResim.TabIndex = 53;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(89, 140);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(199, 21);
            this.cmbTur.TabIndex = 52;
            // 
            // cbOdul
            // 
            this.cbOdul.AutoSize = true;
            this.cbOdul.Location = new System.Drawing.Point(89, 236);
            this.cbOdul.Name = "cbOdul";
            this.cbOdul.Size = new System.Drawing.Size(15, 14);
            this.cbOdul.TabIndex = 51;
            this.cbOdul.UseVisualStyleBackColor = true;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(89, 200);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(199, 20);
            this.txtPuan.TabIndex = 50;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(89, 169);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(199, 20);
            this.txtSure.TabIndex = 49;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(89, 97);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(199, 20);
            this.txtYil.TabIndex = 48;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(89, 61);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(199, 20);
            this.txtYonetmen.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ödül";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "IMDB Puan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Poster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Yıl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Yönetmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Film Adı:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(89, 27);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(199, 20);
            this.txtFilmAd.TabIndex = 38;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(65, 272);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 70);
            this.btnKaydet.TabIndex = 54;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // YeniFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.cbOdul);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAd);
            this.Name = "YeniFilmForm";
            this.Text = "YeniFilmForm";
            this.Load += new System.EventHandler(this.YeniFilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.CheckBox cbOdul;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Button btnKaydet;
    }
}
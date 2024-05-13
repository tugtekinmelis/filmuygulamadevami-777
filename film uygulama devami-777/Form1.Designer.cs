namespace film_uygulama_devami_777
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnYeniFilmForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Image = global::film_uygulama_devami_777.Properties.Resources._001_remove;
            this.btnSil.Location = new System.Drawing.Point(588, 166);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 142);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Film Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::film_uygulama_devami_777.Properties.Resources._003_refresh;
            this.btnGuncelle.Location = new System.Drawing.Point(679, 21);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 137);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Film Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbResim.Location = new System.Drawing.Point(298, 41);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(173, 245);
            this.pbResim.TabIndex = 37;
            this.pbResim.TabStop = false;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(76, 130);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(199, 21);
            this.cmbTur.TabIndex = 36;
            // 
            // cbOdul
            // 
            this.cbOdul.AutoSize = true;
            this.cbOdul.Location = new System.Drawing.Point(76, 226);
            this.cbOdul.Name = "cbOdul";
            this.cbOdul.Size = new System.Drawing.Size(15, 14);
            this.cbOdul.TabIndex = 35;
            this.cbOdul.UseVisualStyleBackColor = true;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(76, 190);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(199, 20);
            this.txtPuan.TabIndex = 34;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(76, 159);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(199, 20);
            this.txtSure.TabIndex = 33;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(76, 87);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(199, 20);
            this.txtYil.TabIndex = 32;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(76, 51);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(199, 20);
            this.txtYonetmen.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ödül";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "IMDB Puan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Poster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yıl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Yönetmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Film Adı:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(76, 17);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(199, 20);
            this.txtFilmAd.TabIndex = 22;
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.AllowUserToAddRows = false;
            this.dgwFilmler.AllowUserToDeleteRows = false;
            this.dgwFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(27, 314);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.ReadOnly = true;
            this.dgwFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFilmler.Size = new System.Drawing.Size(829, 317);
            this.dgwFilmler.TabIndex = 21;
            this.dgwFilmler.SelectionChanged += new System.EventHandler(this.dgwFilmler_SelectionChanged);
            // 
            // btnYeniFilmForm
            // 
            this.btnYeniFilmForm.Image = global::film_uygulama_devami_777.Properties.Resources._002_plus;
            this.btnYeniFilmForm.Location = new System.Drawing.Point(495, 20);
            this.btnYeniFilmForm.Name = "btnYeniFilmForm";
            this.btnYeniFilmForm.Size = new System.Drawing.Size(156, 138);
            this.btnYeniFilmForm.TabIndex = 41;
            this.btnYeniFilmForm.Text = "Yeni Film Ekle";
            this.btnYeniFilmForm.UseVisualStyleBackColor = true;
            this.btnYeniFilmForm.Click += new System.EventHandler(this.btnYeniFilmForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 648);
            this.Controls.Add(this.btnYeniFilmForm);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
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
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
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
        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnYeniFilmForm;
    }
}


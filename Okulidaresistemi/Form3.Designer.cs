namespace Okulidaresistemi
{
    partial class Form3
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
            this.txtYonetimId = new System.Windows.Forms.TextBox();
            this.btnYonetimGuncelle = new System.Windows.Forms.Button();
            this.btnYonetimSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYonetimTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYonetimAd = new System.Windows.Forms.TextBox();
            this.btnYonetimEkle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtYonetimGorev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // txtYonetimId
            // 
            this.txtYonetimId.Location = new System.Drawing.Point(192, 238);
            this.txtYonetimId.Name = "txtYonetimId";
            this.txtYonetimId.ReadOnly = true;
            this.txtYonetimId.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimId.TabIndex = 34;
            // 
            // btnYonetimGuncelle
            // 
            this.btnYonetimGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetimGuncelle.Location = new System.Drawing.Point(423, 326);
            this.btnYonetimGuncelle.Name = "btnYonetimGuncelle";
            this.btnYonetimGuncelle.Size = new System.Drawing.Size(129, 55);
            this.btnYonetimGuncelle.TabIndex = 31;
            this.btnYonetimGuncelle.Text = "Mevcut Kaydı Güncelle";
            this.btnYonetimGuncelle.UseVisualStyleBackColor = true;
            this.btnYonetimGuncelle.Click += new System.EventHandler(this.btnYonetimGuncelle_Click);
            // 
            // btnYonetimSil
            // 
            this.btnYonetimSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetimSil.Location = new System.Drawing.Point(423, 265);
            this.btnYonetimSil.Name = "btnYonetimSil";
            this.btnYonetimSil.Size = new System.Drawing.Size(129, 55);
            this.btnYonetimSil.TabIndex = 30;
            this.btnYonetimSil.Text = "Mevcut Kaydı Sil";
            this.btnYonetimSil.UseVisualStyleBackColor = true;
            this.btnYonetimSil.Click += new System.EventHandler(this.btnYonetimSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(151, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipi";
            // 
            // txtYonetimTip
            // 
            this.txtYonetimTip.Location = new System.Drawing.Point(192, 316);
            this.txtYonetimTip.Name = "txtYonetimTip";
            this.txtYonetimTip.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimTip.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Görevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ad Soyad";
            // 
            // txtYonetimAd
            // 
            this.txtYonetimAd.Location = new System.Drawing.Point(192, 264);
            this.txtYonetimAd.Name = "txtYonetimAd";
            this.txtYonetimAd.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimAd.TabIndex = 22;
            // 
            // btnYonetimEkle
            // 
            this.btnYonetimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetimEkle.Location = new System.Drawing.Point(423, 204);
            this.btnYonetimEkle.Name = "btnYonetimEkle";
            this.btnYonetimEkle.Size = new System.Drawing.Size(129, 55);
            this.btnYonetimEkle.TabIndex = 21;
            this.btnYonetimEkle.Text = "Yeni Kayıt Ekle";
            this.btnYonetimEkle.UseVisualStyleBackColor = true;
            this.btnYonetimEkle.Click += new System.EventHandler(this.btnYonetimEkle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(67, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(550, 125);
            this.dataGridView2.TabIndex = 20;
            // 
            // txtYonetimGorev
            // 
            this.txtYonetimGorev.Location = new System.Drawing.Point(192, 290);
            this.txtYonetimGorev.Name = "txtYonetimGorev";
            this.txtYonetimGorev.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimGorev.TabIndex = 36;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.txtYonetimGorev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYonetimId);
            this.Controls.Add(this.btnYonetimGuncelle);
            this.Controls.Add(this.btnYonetimSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYonetimTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYonetimAd);
            this.Controls.Add(this.btnYonetimEkle);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form3";
            this.Text = "Okul Yönetim";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYonetimId;
        private System.Windows.Forms.Button btnYonetimGuncelle;
        private System.Windows.Forms.Button btnYonetimSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYonetimTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYonetimAd;
        private System.Windows.Forms.Button btnYonetimEkle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtYonetimGorev;
    }
}
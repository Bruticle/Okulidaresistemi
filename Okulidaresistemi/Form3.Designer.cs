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
            this.label4 = new System.Windows.Forms.Label();
            this.txtYonetimTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYonetimAd = new System.Windows.Forms.TextBox();
            this.btnYonetimEkle = new System.Windows.Forms.Button();
            this.txtYonetimGorev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // txtYonetimId
            // 
            this.txtYonetimId.Location = new System.Drawing.Point(92, 12);
            this.txtYonetimId.Name = "txtYonetimId";
            this.txtYonetimId.ReadOnly = true;
            this.txtYonetimId.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimId.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipi";
            // 
            // txtYonetimTip
            // 
            this.txtYonetimTip.Location = new System.Drawing.Point(92, 90);
            this.txtYonetimTip.Name = "txtYonetimTip";
            this.txtYonetimTip.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimTip.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Görevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ad Soyad";
            // 
            // txtYonetimAd
            // 
            this.txtYonetimAd.Location = new System.Drawing.Point(92, 38);
            this.txtYonetimAd.Name = "txtYonetimAd";
            this.txtYonetimAd.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimAd.TabIndex = 22;
            // 
            // btnYonetimEkle
            // 
            this.btnYonetimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetimEkle.Location = new System.Drawing.Point(92, 116);
            this.btnYonetimEkle.Name = "btnYonetimEkle";
            this.btnYonetimEkle.Size = new System.Drawing.Size(129, 55);
            this.btnYonetimEkle.TabIndex = 21;
            this.btnYonetimEkle.Text = "Yeni Kayıt Ekle";
            this.btnYonetimEkle.UseVisualStyleBackColor = true;
            this.btnYonetimEkle.Click += new System.EventHandler(this.btnYonetimEkle_Click);
            // 
            // txtYonetimGorev
            // 
            this.txtYonetimGorev.Location = new System.Drawing.Point(92, 64);
            this.txtYonetimGorev.Name = "txtYonetimGorev";
            this.txtYonetimGorev.Size = new System.Drawing.Size(198, 20);
            this.txtYonetimGorev.TabIndex = 36;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 179);
            this.Controls.Add(this.txtYonetimGorev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYonetimId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYonetimTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYonetimAd);
            this.Controls.Add(this.btnYonetimEkle);
            this.Name = "Form3";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYonetimId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYonetimTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYonetimAd;
        private System.Windows.Forms.Button btnYonetimEkle;
        private System.Windows.Forms.TextBox txtYonetimGorev;
    }
}
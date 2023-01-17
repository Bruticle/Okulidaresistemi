namespace Okulidaresistemi
{
    partial class Form2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciBolum = new System.Windows.Forms.TextBox();
            this.dateOgrenciKayit = new System.Windows.Forms.DateTimePicker();
            this.dateOgrenciDt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(122, 168);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 55);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Yeni Kayıt Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(122, 38);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciAd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kayıt Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğrenci No";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(122, 90);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(60, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bölüm";
            // 
            // txtOgrenciBolum
            // 
            this.txtOgrenciBolum.Location = new System.Drawing.Point(122, 142);
            this.txtOgrenciBolum.Name = "txtOgrenciBolum";
            this.txtOgrenciBolum.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciBolum.TabIndex = 12;
            // 
            // dateOgrenciKayit
            // 
            this.dateOgrenciKayit.Location = new System.Drawing.Point(122, 64);
            this.dateOgrenciKayit.Name = "dateOgrenciKayit";
            this.dateOgrenciKayit.Size = new System.Drawing.Size(198, 20);
            this.dateOgrenciKayit.TabIndex = 16;
            // 
            // dateOgrenciDt
            // 
            this.dateOgrenciDt.Location = new System.Drawing.Point(122, 116);
            this.dateOgrenciDt.Name = "dateOgrenciDt";
            this.dateOgrenciDt.Size = new System.Drawing.Size(198, 20);
            this.dateOgrenciDt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(122, 12);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.ReadOnly = true;
            this.txtOgrenciId.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciId.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.dateOgrenciDt);
            this.Controls.Add(this.dateOgrenciKayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOgrenciBolum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form2";
            this.Text = "Öğrenci";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciBolum;
        private System.Windows.Forms.DateTimePicker dateOgrenciKayit;
        private System.Windows.Forms.DateTimePicker dateOgrenciDt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciId;
    }
}
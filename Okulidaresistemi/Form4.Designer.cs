namespace Okulidaresistemi
{
    partial class Form4
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
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.txtDersOkulYonetimId = new System.Windows.Forms.TextBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(133, 64);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(198, 20);
            this.txtDersKredi.TabIndex = 44;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(133, 12);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.ReadOnly = true;
            this.txtDersId.Size = new System.Drawing.Size(198, 20);
            this.txtDersId.TabIndex = 43;
            // 
            // txtDersOkulYonetimId
            // 
            this.txtDersOkulYonetimId.Location = new System.Drawing.Point(133, 90);
            this.txtDersOkulYonetimId.Name = "txtDersOkulYonetimId";
            this.txtDersOkulYonetimId.Size = new System.Drawing.Size(198, 20);
            this.txtDersOkulYonetimId.TabIndex = 40;
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(133, 38);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(198, 20);
            this.txtDersAd.TabIndex = 39;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(133, 116);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(129, 55);
            this.btnDersEkle.TabIndex = 38;
            this.btnDersEkle.Text = "Yeni Kayıt Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "OkulYonetimId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Kredisi";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtDersId);
            this.Controls.Add(this.txtDersOkulYonetimId);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.btnDersEkle);
            this.Name = "Form4";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.TextBox txtDersOkulYonetimId;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
namespace Okulidaresistemi
{
    partial class Form5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciDersOgrenciId = new System.Windows.Forms.TextBox();
            this.txtOgrenciDersId = new System.Windows.Forms.TextBox();
            this.txtOgrenciDersDersId = new System.Windows.Forms.TextBox();
            this.btnOgrenciDersEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ogrenci Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ders Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Id";
            // 
            // txtOgrenciDersOgrenciId
            // 
            this.txtOgrenciDersOgrenciId.Location = new System.Drawing.Point(96, 63);
            this.txtOgrenciDersOgrenciId.Name = "txtOgrenciDersOgrenciId";
            this.txtOgrenciDersOgrenciId.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciDersOgrenciId.TabIndex = 56;
            // 
            // txtOgrenciDersId
            // 
            this.txtOgrenciDersId.Location = new System.Drawing.Point(96, 11);
            this.txtOgrenciDersId.Name = "txtOgrenciDersId";
            this.txtOgrenciDersId.ReadOnly = true;
            this.txtOgrenciDersId.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciDersId.TabIndex = 55;
            // 
            // txtOgrenciDersDersId
            // 
            this.txtOgrenciDersDersId.Location = new System.Drawing.Point(96, 37);
            this.txtOgrenciDersDersId.Name = "txtOgrenciDersDersId";
            this.txtOgrenciDersDersId.Size = new System.Drawing.Size(198, 20);
            this.txtOgrenciDersDersId.TabIndex = 51;
            // 
            // btnOgrenciDersEkle
            // 
            this.btnOgrenciDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciDersEkle.Location = new System.Drawing.Point(96, 89);
            this.btnOgrenciDersEkle.Name = "btnOgrenciDersEkle";
            this.btnOgrenciDersEkle.Size = new System.Drawing.Size(129, 55);
            this.btnOgrenciDersEkle.TabIndex = 50;
            this.btnOgrenciDersEkle.Text = "Yeni Kayıt Ekle";
            this.btnOgrenciDersEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciDersEkle.Click += new System.EventHandler(this.btnOgrenciDersEkle_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 154);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciDersOgrenciId);
            this.Controls.Add(this.txtOgrenciDersId);
            this.Controls.Add(this.txtOgrenciDersDersId);
            this.Controls.Add(this.btnOgrenciDersEkle);
            this.Name = "Form5";
            this.Text = "Öğrenci Ders";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciDersOgrenciId;
        private System.Windows.Forms.TextBox txtOgrenciDersId;
        private System.Windows.Forms.TextBox txtOgrenciDersDersId;
        private System.Windows.Forms.Button btnOgrenciDersEkle;
    }
}
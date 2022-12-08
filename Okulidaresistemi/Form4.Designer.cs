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
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.txtDersOkulYonetimId = new System.Windows.Forms.TextBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(192, 290);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(198, 20);
            this.txtDersKredi.TabIndex = 44;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(192, 238);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.ReadOnly = true;
            this.txtDersId.Size = new System.Drawing.Size(198, 20);
            this.txtDersId.TabIndex = 43;
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersGuncelle.Location = new System.Drawing.Point(423, 326);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(129, 55);
            this.btnDersGuncelle.TabIndex = 42;
            this.btnDersGuncelle.Text = "Mevcut Kaydı Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.Location = new System.Drawing.Point(423, 265);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(129, 55);
            this.btnDersSil.TabIndex = 41;
            this.btnDersSil.Text = "Mevcut Kaydı Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // txtDersOkulYonetimId
            // 
            this.txtDersOkulYonetimId.Location = new System.Drawing.Point(192, 316);
            this.txtDersOkulYonetimId.Name = "txtDersOkulYonetimId";
            this.txtDersOkulYonetimId.Size = new System.Drawing.Size(198, 20);
            this.txtDersOkulYonetimId.TabIndex = 40;
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(192, 264);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(198, 20);
            this.txtDersAd.TabIndex = 39;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(423, 204);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(129, 55);
            this.btnDersEkle.TabIndex = 38;
            this.btnDersEkle.Text = "Yeni Kayıt Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(67, 50);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(550, 125);
            this.dataGridView3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "OkulYonetimId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 289);
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
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtDersId);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.txtDersOkulYonetimId);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form4";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDersKredi;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.TextBox txtDersOkulYonetimId;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
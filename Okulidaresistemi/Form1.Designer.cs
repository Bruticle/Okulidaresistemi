namespace Okulidaresistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul İdare Sistemi\'ne Hoşgeldiniz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.öğrenciDersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem1,
            this.listeToolStripMenuItem1});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // girişToolStripMenuItem1
            // 
            this.girişToolStripMenuItem1.Name = "girişToolStripMenuItem1";
            this.girişToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.girişToolStripMenuItem1.Text = "Giriş";
            this.girişToolStripMenuItem1.Click += new System.EventHandler(this.girişToolStripMenuItem1_Click);
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem1.Text = "Liste";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem2,
            this.listeToolStripMenuItem2});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // girişToolStripMenuItem2
            // 
            this.girişToolStripMenuItem2.Name = "girişToolStripMenuItem2";
            this.girişToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.girişToolStripMenuItem2.Text = "Giriş ";
            this.girişToolStripMenuItem2.Click += new System.EventHandler(this.girişToolStripMenuItem2_Click);
            // 
            // listeToolStripMenuItem2
            // 
            this.listeToolStripMenuItem2.Name = "listeToolStripMenuItem2";
            this.listeToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.listeToolStripMenuItem2.Text = "Liste";
            this.listeToolStripMenuItem2.Click += new System.EventHandler(this.listeToolStripMenuItem2_Click);
            // 
            // öğrenciDersToolStripMenuItem
            // 
            this.öğrenciDersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grişToolStripMenuItem,
            this.listeToolStripMenuItem3});
            this.öğrenciDersToolStripMenuItem.Name = "öğrenciDersToolStripMenuItem";
            this.öğrenciDersToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.öğrenciDersToolStripMenuItem.Text = "Öğrenci Ders";
            // 
            // grişToolStripMenuItem
            // 
            this.grişToolStripMenuItem.Name = "grişToolStripMenuItem";
            this.grişToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.grişToolStripMenuItem.Text = "Griş";
            this.grişToolStripMenuItem.Click += new System.EventHandler(this.grişToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem3
            // 
            this.listeToolStripMenuItem3.Name = "listeToolStripMenuItem3";
            this.listeToolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem3.Text = "Liste";
            this.listeToolStripMenuItem3.Click += new System.EventHandler(this.listeToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 211);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Okul İdare Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem3;
    }
}


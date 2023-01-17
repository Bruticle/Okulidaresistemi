namespace Okulidaresistemi
{
    partial class Form9
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciDersSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(550, 125);
            this.dataGridView4.TabIndex = 50;
            // 
            // btnOgrenciDersSil
            // 
            this.btnOgrenciDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciDersSil.Location = new System.Drawing.Point(579, 12);
            this.btnOgrenciDersSil.Name = "btnOgrenciDersSil";
            this.btnOgrenciDersSil.Size = new System.Drawing.Size(111, 125);
            this.btnOgrenciDersSil.TabIndex = 54;
            this.btnOgrenciDersSil.Text = "Mevcut Kaydı Sil";
            this.btnOgrenciDersSil.UseVisualStyleBackColor = true;
            this.btnOgrenciDersSil.Click += new System.EventHandler(this.btnOgrenciDersSil_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 147);
            this.Controls.Add(this.btnOgrenciDersSil);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Form9";
            this.Text = "Öğrenci Ders Listesi";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnOgrenciDersSil;
    }
}
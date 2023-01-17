using Okulidaresistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okulidaresistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnYonetimEkle_Click(object sender, EventArgs e)
        {
            OkulYonetim ekle = new OkulYonetim();
            ekle.AdSoyad = txtYonetimAd.Text;
            ekle.Gorevi = txtYonetimGorev.Text;
            ekle.YonetimTip = int.Parse(txtYonetimTip.Text);
            okul.OkulYonetim.Add(ekle);
            okul.SaveChanges();
            MessageBox.Show("Kayıt Eklendi.");
        }
        
    }
}

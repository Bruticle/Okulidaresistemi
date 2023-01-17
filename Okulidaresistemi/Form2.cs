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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ekle = new Ogrenci();
            ekle.AdSoyad = txtOgrenciAd.Text;
            ekle.KayitTarih = dateOgrenciKayit.Value;
            ekle.OgrenciNo = int.Parse(txtOgrenciNo.Text);
            ekle.Dtarih = dateOgrenciDt.Value;
            ekle.Bolum = txtOgrenciBolum.Text;
            okul.Ogrenci.Add(ekle);
            okul.SaveChanges();
            MessageBox.Show("Kayıt Eklendi.");
        }

        

       

        
    }
}

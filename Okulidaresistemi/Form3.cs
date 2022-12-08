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
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }

        private void btnYonetimEkle_Click(object sender, EventArgs e)
        {
            OkulYonetim ekle = new OkulYonetim();
            ekle.AdSoyad = txtYonetimAd.Text;
            ekle.Gorevi = txtYonetimGorev.Text;
            ekle.YonetimTip = int.Parse(txtYonetimTip.Text);
            okul.OkulYonetim.Add(ekle);
            okul.SaveChanges();
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }

        private void btnYonetimSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            OkulYonetim sil = okul.OkulYonetim.Where(x => x.Id == id).FirstOrDefault();
            okul.OkulYonetim.Remove(sil);
            okul.SaveChanges();
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }

        private void btnYonetimGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            OkulYonetim guncelle = okul.OkulYonetim.Where(x => x.Id == id).FirstOrDefault();
            guncelle.AdSoyad = txtYonetimAd.Text;
            guncelle.Gorevi = txtYonetimGorev.Text;
            guncelle.YonetimTip = int.Parse(txtYonetimTip.Text);
            okul.SaveChanges();
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }
    }
}

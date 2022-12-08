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
            dataGridView1.DataSource=okul.Ogrenci.ToList();
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
            dataGridView1.DataSource = okul.Ogrenci.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Ogrenci sil = okul.Ogrenci.Where(x => x.Id == id).FirstOrDefault();
            okul.Ogrenci.Remove(sil);
            okul.SaveChanges();
            dataGridView1.DataSource = okul.Ogrenci.ToList();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Ogrenci guncelle = okul.Ogrenci.Where(x => x.Id == id).FirstOrDefault();
            guncelle.AdSoyad = txtOgrenciAd.Text;
            guncelle.KayitTarih = dateOgrenciKayit.Value;
            guncelle.OgrenciNo = int.Parse(txtOgrenciNo.Text);
            guncelle.Dtarih = dateOgrenciDt.Value;
            guncelle.Bolum = txtOgrenciBolum.Text;
            okul.SaveChanges();
            dataGridView1.DataSource = okul.Ogrenci.ToList();
        }
    }
}

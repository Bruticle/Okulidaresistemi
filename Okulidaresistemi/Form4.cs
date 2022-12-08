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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = okul.Ders.ToList();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            Ders ekle = new Ders();
            ekle.Ad = txtDersAd.Text;
            ekle.Kredisi = int.Parse(txtDersKredi.Text);
            ekle.OkulYonetimId = int.Parse(txtDersOkulYonetimId.Text);
            okul.Ders.Add(ekle);
            okul.SaveChanges();
            dataGridView3.DataSource = okul.Ders.ToList();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Ders sil = okul.Ders.Where(x => x.Id == id).FirstOrDefault();
            okul.Ders.Remove(sil);
            okul.SaveChanges();
            dataGridView3.DataSource = okul.Ders.ToList();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Ders guncelle = okul.Ders.Where(x => x.Id == id).FirstOrDefault();
            guncelle.Ad = txtDersAd.Text;
            guncelle.Kredisi = int.Parse(txtDersKredi.Text);
            guncelle.OkulYonetimId = int.Parse(txtDersOkulYonetimId.Text);
            okul.SaveChanges();
            dataGridView3.DataSource = okul.Ders.ToList();
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnOgrenciDersEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ekle = new OgrenciDers();
            ekle.DersId = int.Parse(txtOgrenciDersDersId.Text);
            ekle.OgrenciId = int.Parse(txtOgrenciDersOgrenciId.Text);
            okul.OgrenciDers.Add(ekle);
            okul.SaveChanges();
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }

        private void btnOgrenciDersSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            OgrenciDers sil = okul.OgrenciDers.Where(x => x.Id == id).FirstOrDefault();
            okul.OgrenciDers.Remove(sil);
            okul.SaveChanges();
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }

        private void btnOgrenciDersGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            OgrenciDers guncelle = okul.OgrenciDers.Where(x => x.Id == id).FirstOrDefault();
            guncelle.DersId = int.Parse(txtOgrenciDersDersId.Text);
            guncelle.OgrenciId = int.Parse(txtOgrenciDersOgrenciId.Text);
            okul.SaveChanges();
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }
    }
}

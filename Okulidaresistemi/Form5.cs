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
            MessageBox.Show("Kayıt Eklendi.");
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

 
        
    }
}

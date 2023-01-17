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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void btnOgrenciDersSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            OgrenciDers sil = okul.OgrenciDers.Where(x => x.Id == id).FirstOrDefault();
            okul.OgrenciDers.Remove(sil);
            okul.SaveChanges();
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = okul.OgrenciDers.ToList();
        }
    }
}

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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Ogrenci sil = okul.Ogrenci.Where(x => x.Id == id).FirstOrDefault();
            okul.Ogrenci.Remove(sil);
            okul.SaveChanges();
            dataGridView1.DataSource = okul.Ogrenci.ToList();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = okul.Ogrenci.ToList();
        }
    }
}

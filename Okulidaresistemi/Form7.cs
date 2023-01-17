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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void btnYonetimSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            OkulYonetim sil = okul.OkulYonetim.Where(x => x.Id == id).FirstOrDefault();
            okul.OkulYonetim.Remove(sil);
            okul.SaveChanges();
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = okul.OkulYonetim.ToList();
        }
    }
}

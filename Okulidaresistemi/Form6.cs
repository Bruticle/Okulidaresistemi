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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        okulidareEntities okul = new okulidareEntities();
        private void Form6_Load(object sender, EventArgs e)
        {
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

    }
}

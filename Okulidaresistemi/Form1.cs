﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
        }

        private void grişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.ShowDialog();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.ShowDialog();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.ShowDialog();
        }

        private void listeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paytm_Project
{
    public partial class homelist : UserControl
    {
        public homelist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             Form2 hm = new Form2();
            hm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmpassbook pass = new frmpassbook();
            pass.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmadd add = new frmadd();
            add.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void homelist_Load(object sender, EventArgs e)
        {

        }
    }
}

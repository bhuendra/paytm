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
    public partial class paytm1 : UserControl
    {
        public paytm1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            panel3.Width = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel3.Width = 200;
           // panel4.Hide();
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Width = 0;
          
            panel4.Show();
        }

       
        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.Show();
        }

        

      

       

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
            string a = Convert.ToString(Form3.strbal);
            label17.Text = Form3.strname;
            label22.Text = a;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmhome hm = new frmhome();
            hm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            Frmcode qr = new Frmcode();
            qr.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }
    }
}

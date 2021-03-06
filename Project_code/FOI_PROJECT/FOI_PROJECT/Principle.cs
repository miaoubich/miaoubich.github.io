﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOI_PROJECT
{
    public partial class Principle : Form
    {
        public Principle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items it = new Items();
            it.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User us = new User();
            us.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.utype == "administrator")
            {
                this.Hide();
                Client c = new Client();
                c.Show();
            }
        }

        private void Principle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

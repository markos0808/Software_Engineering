﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            PromjenaPozicije pp = new PromjenaPozicije();
            pp.promjena(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            Gumbi gmb = new Gumbi();
            gmb.napraviGumbe(this);
        }
    }
}

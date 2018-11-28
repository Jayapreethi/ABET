﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVirtualExamIntro : Form
    {
        public frmVirtualExamIntro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VirtualExam ObjVirtualExam = new VirtualExam();
            ObjVirtualExam.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hmpage = new HomePage();
            hmpage.Show();
        }
    }
}

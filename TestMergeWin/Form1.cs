﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMergeWin
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        private void btn_Div_Click(object sender, EventArgs e)
        {
			tb_Res.Text = (nud_FirstNumber.Value - nud_SecondNumber.Value).ToString();

		}
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datatypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{int.MinValue},Max:{int.MaxValue}"); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{sbyte.MinValue},Max:{sbyte.MaxValue}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{byte.MinValue},Max:{byte.MaxValue}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{short.MinValue},Max:{short.MaxValue}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{ushort.MinValue},Max:{ushort.MaxValue}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{decimal.MinValue},Max:{decimal.MaxValue}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{float.MinValue},Max:{float.MaxValue}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{double.MinValue},Max:{double.MaxValue}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{uint.MinValue},Max:{uint.MaxValue}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{long.MinValue},Max:{long.MaxValue}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min:{ulong.MinValue},Max:{ulong.MaxValue}");
        }
    }
}

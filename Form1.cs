﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz...");

        }

        private void tikla_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Button1 Nesnesine Tıkladınız.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

        }

    }
    }

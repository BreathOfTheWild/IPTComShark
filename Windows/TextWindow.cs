﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTComShark.Windows
{
    public partial class TextWindow : Form
    {
        public TextWindow(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }
    }
}

﻿using System.Windows.Forms;

// Задача 2 Беккер Е.Н
namespace W8_T2_TextBoxAndNumericUpDown
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.ValueChanged += delegate
            {
                textBox1.Text = numericUpDown1.Value.ToString();
            };
        }
    }
}
